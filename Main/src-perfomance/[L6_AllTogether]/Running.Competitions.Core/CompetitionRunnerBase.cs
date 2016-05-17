﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Helpers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running.Messages;
using BenchmarkDotNet.Toolchains.InProcess;
using BenchmarkDotNet.Validators;

using JetBrains.Annotations;

namespace BenchmarkDotNet.Running.Competitions.Core
{
	[PublicAPI]
	[SuppressMessage("ReSharper", "VirtualMemberNeverOverriden.Global")]
	[SuppressMessage("ReSharper", "SuggestVarOrType_BuiltInTypes")]
	public abstract class CompetitionRunnerBase
	{
		public void RunCompetition(Type benchmarkType, ICompetitionConfig baseConfig)
		{
			baseConfig = baseConfig ?? new ManualCompetitionConfig();

			ValidateCompetitionSetup(benchmarkType);

			var competitionConfig = CreateBenchmarkConfig(baseConfig);

			bool runSucceed = false;
			IMessage[] messages;
			Summary summary = null;
			try
			{
				var competitionState = CompetitionCore.Run(benchmarkType, competitionConfig, baseConfig.MaxRunCount);
				messages = competitionState.GetMessages();
				summary = competitionState.LastRunSummary;
				runSucceed = true;
			}
			finally
			{
				OnAfterRun(runSucceed, competitionConfig, summary);
			}

			ReportMessagesToUser(messages);
		}

		protected virtual void ValidateCompetitionSetup(Type benchmarkType)
		{
			if (EnvironmentInfo.GetCurrent().HasAttachedDebugger)
			{
				var assembly = benchmarkType.Assembly;
				if (assembly.IsDebugAssembly())
					throw new InvalidOperationException(
						$"Set the solution configuration into Release mode. Assembly {assembly.GetName().Name} was build as debug.");

				foreach (var referencedAssemblyName in assembly.GetReferencedAssemblies())
				{
					var refAssembly = Assembly.Load(referencedAssemblyName);
					if (refAssembly.IsDebugAssembly())
						throw new InvalidOperationException(
							$"Set the solution configuration into Release mode. Assembly {refAssembly.GetName().Name} was build as debug.");
				}
			}
		}

		protected virtual void OnAfterRun(bool runSucceed, IConfig competitionConfig, Summary summary) { }

		#region Messages
		protected abstract void ReportAsError(string messages);
		protected abstract void ReportAsWarning(string messages);

		private void ReportMessagesToUser(IMessage[] messages)
		{
			if (messages == null)
				return;

			var errorMessages = GetMessageLines(messages, m => m.MessageSeverity > MessageSeverity.Warning);
			var warningMessages = GetMessageLines(messages, m => m.MessageSeverity == MessageSeverity.Warning);
			var infoMessages = GetMessageLines(messages, m => m.MessageSeverity < MessageSeverity.Warning);

			var allMessages = new List<string>(errorMessages.Length + warningMessages.Length + infoMessages.Length + 3);

			bool hasErrors = errorMessages.Length > 0;
			bool hasWarnings = warningMessages.Length > 0;
			bool hasInfo = infoMessages.Length > 0;

			if (!hasErrors && !hasWarnings)
				return;

			// ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
			if (hasErrors)
			{
				allMessages.Add("Execution failed, details below.");
			}
			else
			{
				allMessages.Add("Test completed with warnings, details below.");
			}

			if (hasErrors)
			{
				allMessages.Add("Errors:");
				allMessages.AddRange(errorMessages);
			}
			if (hasWarnings)
			{
				allMessages.Add("Warnings:");
				allMessages.AddRange(warningMessages);
			}
			if (hasInfo)
			{
				allMessages.Add("Diagnostic messages:");
				allMessages.AddRange(infoMessages);
			}

			if (hasErrors)
			{
				ReportAsError(string.Join(Environment.NewLine, allMessages));
			}
			else
			{
				ReportAsWarning(string.Join(Environment.NewLine, allMessages));
			}
		}

		private string[] GetMessageLines(IMessage[] messages, Func<IMessage, bool> filter)
		{
			var result =
				from message in messages.Where(filter)
				orderby
					message.MessageSource,
					(int)message.MessageSeverity descending,
					message.RunNumber,
					message.RunMessageNumber
				select $"    * Run #{message.RunNumber}: {message.MessageText}";

			return result.ToArray();
		}
		#endregion

		#region Create config
		private IConfig CreateBenchmarkConfig(ICompetitionConfig competitionConfig)
		{
			var result = new ManualConfig();

			result.Add(OverrideJobs(competitionConfig).ToArray());
			result.Add(OverrideExporters(competitionConfig).ToArray());
			result.Add(OverrideLoggers(competitionConfig).ToArray());
			result.Add(OverrideDiagnosers(competitionConfig).ToArray());

			result.Add(GetColumns(competitionConfig).ToArray());
			result.Add(GetValidators(competitionConfig).ToArray());
			result.Add(GetAnalysers(competitionConfig).ToArray());

			return result;
		}

		#region Override config
		protected virtual List<IJob> OverrideJobs(ICompetitionConfig baseConfig) =>
			baseConfig.GetJobs().ToList();

		protected virtual List<IColumn> OverrideColumns(ICompetitionConfig baseConfig) =>
			baseConfig.GetColumns().ToList();

		protected virtual List<IExporter> OverrideExporters(ICompetitionConfig baseConfig) =>
			baseConfig.GetExporters().ToList();

		protected virtual List<ILogger> OverrideLoggers(ICompetitionConfig baseConfig) =>
			baseConfig.GetLoggers().ToList();

		protected virtual List<IDiagnoser> OverrideDiagnosers(ICompetitionConfig baseConfig) =>
			baseConfig.GetDiagnosers().ToList();

		protected virtual List<IAnalyser> OverrideAnalysers(ICompetitionConfig baseConfig) =>
			baseConfig.GetAnalysers().ToList();

		protected virtual List<IValidator> OverrideValidators(ICompetitionConfig baseConfig) =>
			baseConfig.GetValidators().ToList();
		#endregion

		private List<IColumn> GetColumns(ICompetitionConfig competitionConfig)
		{
			var result = OverrideColumns(competitionConfig);
			result.AddRange(
				new[]
				{
					StatisticColumn.Min,
					BaselineDiffColumn.Scaled50,
					BaselineDiffColumn.Scaled85,
					BaselineDiffColumn.Scaled95,
					StatisticColumn.Max
				});
			return result;
		}

		private List<IValidator> GetValidators(ICompetitionConfig competitionConfig)
		{
			var result = OverrideValidators(competitionConfig);
			if (competitionConfig.GetJobs().Any(j => j.Toolchain is InProcessToolchain))
			{
				// ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
				if (competitionConfig.AnnotateOnRun)
				{
					result.Insert(0, InProcessValidator.FailOnError);
				}
				else
				{
					result.Insert(0, InProcessValidator.DontFailOnError);
				}
			}

			if (EnvironmentInfo.GetCurrent().HasAttachedDebugger)
			{
				result.RemoveAll(v => v is JitOptimizationsValidator);
			}
			else
			{
				if (result.All(v => !(v is JitOptimizationsValidator)))
				{
					result.Insert(0, JitOptimizationsValidator.FailOnError);
				}
			}
			result.Insert(0, new RunStateSlots());

			return result;
		}

		private List<IAnalyser> GetAnalysers(ICompetitionConfig competitionConfig)
		{
			var result = OverrideAnalysers(competitionConfig);
			if (!competitionConfig.DisableValidation)
			{
				var annotator = new CompetitionLimitsAnnotateAnalyser
				{
					AllowSlowBenchmarks = competitionConfig.AllowSlowBenchmarks,
					AnnotateOnRun = competitionConfig.AnnotateOnRun,
					IgnoreExistingAnnotations = competitionConfig.IgnoreExistingAnnotations,
					DefaultCompetitionLimit = competitionConfig.DefaultCompetitionLimit,
					MaxRuns = 3,
					AdditionalRunsOnAnnotate = 2
				};
				result.Add(annotator);
			}
			return result;
		}
		#endregion
	}
}