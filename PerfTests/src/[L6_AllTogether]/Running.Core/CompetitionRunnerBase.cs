﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Helpers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Toolchains.InProcess;
using BenchmarkDotNet.Validators;

using CodeJam.PerfTests.Analysers;
using CodeJam.PerfTests.Columns;
using CodeJam.PerfTests.Configs;
using CodeJam.PerfTests.Loggers;
using CodeJam.PerfTests.Running.Limits;
using CodeJam.PerfTests.Running.Messages;
using CodeJam.Strings;

using JetBrains.Annotations;

namespace CodeJam.PerfTests.Running.Core
{
	/// <summary>Base class for competition benchmark runners</summary>
	[PublicAPI]
	[SuppressMessage("ReSharper", "ArrangeBraces_using")]
	[SuppressMessage("ReSharper", "ArrangeRedundantParentheses")]
	[SuppressMessage("ReSharper", "SuggestVarOrType_BuiltInTypes")]
	[SuppressMessage("ReSharper", "VirtualMemberNeverOverridden.Global")]
	public abstract class CompetitionRunnerBase
	{
		/// <summary>Base class for competition runner's host logger.</summary>
		/// <seealso cref="Loggers.HostLogger"/>
		protected abstract class HostLogger : Loggers.HostLogger
		{
			/// <summary>Initializes a new instance of the <see cref="HostLogger"/> class.</summary>
			/// <param name="wrappedLogger">The logger to redirect the output. Cannot be null.</param>
			/// <param name="logMode">Host logging mode.</param>
			protected HostLogger([NotNull] ILogger wrappedLogger, HostLogMode logMode)
				: base(wrappedLogger, logMode) { }
		}

		#region Helpers
		private static void SetCurrentDirectoryIfNotNull(string currentDirectory)
		{
			if (currentDirectory.NotNullNorEmpty())
			{
				Environment.CurrentDirectory = currentDirectory;
			}
		}

		private static ICompetitionConfig GetFirstConfig(
			[CanBeNull] Type benchmarkType,
			[CanBeNull] ICompetitionConfig customConfig)
		{
			if (customConfig != null)
				return new ManualCompetitionConfig(customConfig);

			var configSource = benchmarkType?.TryGetMetadataAttribute<ICompetitionConfigSource>();

			return configSource?.Config ?? CompetitionHelpers.DefaultConfig;
		}
		#endregion

		#region Public API (expose these via Competiton classes)
		/// <summary>Runs the benchmark.</summary>
		/// <typeparam name="T">Benchmark class to run.</typeparam>
		/// <param name="competitionConfig">
		/// The competition config.
		/// If<c>null</c> config from <see cref="CompetitionConfigAttribute"/> will be used.
		/// </param>
		/// <returns>The state of the competition.</returns>
		[NotNull]
		public CompetitionState Run<T>([CanBeNull] ICompetitionConfig competitionConfig = null)
			where T : class =>
				RunCore(typeof(T), competitionConfig);

		/// <summary>Runs the benchmark.</summary>
		/// <typeparam name="T">Benchmark class to run.</typeparam>
		/// <param name="thisReference">Reference used to infer type of the benchmark.</param>
		/// <param name="competitionConfig">
		/// The competition config.
		/// If<c>null</c> config from <see cref="CompetitionConfigAttribute"/> will be used.
		/// </param>
		/// <returns>The state of the competition.</returns>
		[NotNull]
		public CompetitionState Run<T>(
			[NotNull] T thisReference,
			[CanBeNull] ICompetitionConfig competitionConfig = null)
			where T : class =>
				RunCore(thisReference.GetType(), competitionConfig);

		/// <summary>Runs the benchmark.</summary>
		/// <param name="benchmarkType">Benchmark class to run.</param>
		/// <param name="competitionConfig">
		/// The competition config.
		/// If<c>null</c> config from <see cref="CompetitionConfigAttribute"/> will be used.
		/// </param>
		/// <returns>The state of the competition.</returns>
		[NotNull]
		public CompetitionState Run(
			[NotNull] Type benchmarkType,
			[CanBeNull] ICompetitionConfig competitionConfig = null) =>
				RunCore(benchmarkType, competitionConfig);
		#endregion

		#region Advanced public API (expose these if you wish)
		/// <summary>Runs all benchmarks defined in the assembly.</summary>
		/// <param name="assembly">Assembly with benchmarks to run.</param>
		/// <param name="competitionConfig">
		/// The competition config.
		/// If<c>null</c> config from <see cref="CompetitionConfigAttribute"/> will be used.
		/// </param>
		/// <returns>The state of the competition for each benchmark that was run.</returns>
		[NotNull]
		public IReadOnlyDictionary<Type, CompetitionState> Run(
			[NotNull] Assembly assembly,
			[CanBeNull] ICompetitionConfig competitionConfig = null) =>
				Run(BenchmarkHelpers.GetBenchmarkTypes(assembly), competitionConfig);

		/// <summary>Runs all benchmarks defined in the assembly.</summary>
		/// <param name="benchmarkTypes">Benchmark classes to run.</param>
		/// <param name="competitionConfig">
		/// The competition config.
		/// If<c>null</c> config from <see cref="CompetitionConfigAttribute"/> will be used.
		/// </param>
		/// <returns>The state of the competition for each benchmark that was run.</returns>
		[NotNull]
		public IReadOnlyDictionary<Type, CompetitionState> Run(
			[NotNull] Type[] benchmarkTypes,
			[CanBeNull] ICompetitionConfig competitionConfig = null)
		{
			var result = new Dictionary<Type, CompetitionState>();

			foreach (var benchmarkType in benchmarkTypes)
			{
				result[benchmarkType] = RunCore(benchmarkType, competitionConfig);
			}

			return result;
		}
		#endregion

		/// <summary>Runs the benchmark.</summary>
		/// <param name="benchmarkType">Benchmark class to run.</param>
		/// <param name="competitionConfig">
		/// The competition config.
		/// If<c>null</c> config from <see cref="CompetitionConfigAttribute"/> will be used.
		/// </param>
		/// <returns>State of the run.</returns>
		[NotNull]
		private CompetitionState RunCore(
			[NotNull] Type benchmarkType,
			[CanBeNull] ICompetitionConfig competitionConfig)
		{
			Code.NotNull(benchmarkType, nameof(benchmarkType));

			competitionConfig = PrepareCompetitionConfig(benchmarkType, competitionConfig);
			var benchmarkConfig = CreateBenchmarkConfig(competitionConfig);

			var hostLogger = benchmarkConfig.GetLoggers().OfType<HostLogger>().Single();

			var previousDirectory = Environment.CurrentDirectory;
			var currentDirectory = GetOutputDirectory(benchmarkType.Assembly);
			if (currentDirectory == previousDirectory)
			{
				currentDirectory = null;
				previousDirectory = null;
			}

			CompetitionState competitionState = null;
			try
			{
				SetCurrentDirectoryIfNotNull(currentDirectory);
				try
				{
					competitionState = CompetitionCore.Run(
						benchmarkType, benchmarkConfig,
						competitionConfig.CompetitionMode);

					ProcessRunComplete(competitionConfig, competitionState);
				}
				finally
				{
					ReportHostLogger(hostLogger, competitionState?.LastRunSummary);
				}

				using (Loggers.HostLogger.BeginLogImportant(benchmarkConfig))
				{
					ReportMessagesToUser(competitionConfig, competitionState);
				}
			}
			finally
			{
				Loggers.HostLogger.FlushLoggers(benchmarkConfig);
				SetCurrentDirectoryIfNotNull(previousDirectory);
			}

			return competitionState;
		}

		#region Prepare & run completed logic
		private void ProcessRunComplete(
			[NotNull] ICompetitionConfig competitionConfig,
			[NotNull] CompetitionState competitionState)
		{
			var logger = competitionState.Logger;
			var summary = competitionState.LastRunSummary;

			if (logger == null)
				return;

			if (competitionConfig.CompetitionMode.RunMode.DetailedLogging)
			{
				var messages = competitionState.GetMessages();

				if (messages.Any())
				{
					logger.WriteSeparatorLine("All messages");
					foreach (var message in messages)
					{
						logger.LogMessage(message);
					}
				}
				else
				{
					logger.WriteSeparatorLine();
					logger.WriteLineInfo($"{Loggers.HostLogger.LogVerbosePrefix} No messages in run.");
				}
			}
			else if (summary != null)
			{
				using (Loggers.HostLogger.BeginLogImportant(summary.Config))
				{
					var summaryLogger = DumpSummaryToHostLogger
						? logger
						: new CompositeLogger(
							summary.Config
								.GetLoggers()
								.Where(l => !(l is HostLogger))
								.ToArray());

					// Dumping the benchmark summary
					summaryLogger.WriteSeparatorLine("Summary");
					MarkdownExporter.Console.ExportToLog(summary, summaryLogger);
				}
			}
		}
		#endregion

		#region Override test running behavior
		/// <summary>Returns output directory that should be used for running the test.</summary>
		/// <param name="targetAssembly">The target assembly tests will be run for.</param>
		/// <returns>
		/// Output directory that should be used for running the test or <c>null</c> if the current directory should be used.
		/// </returns>
		protected virtual string GetOutputDirectory(Assembly targetAssembly) => null;

		/// <summary>Gets a value indicating whether the last run summary should be dumped into host logger.</summary>
		/// <value>
		/// <c>true</c> if the last run summary should be dumped into host logger; otherwise, <c>false</c>.
		/// </value>
		protected virtual bool DumpSummaryToHostLogger => true;
		#endregion

		#region Host-related logic
		/// <summary>Creates a host logger.</summary>
		/// <param name="hostLogMode">The host log mode.</param>
		/// <returns>An instance of <see cref="HostLogger"/></returns>
		[NotNull]
		protected abstract HostLogger CreateHostLogger(HostLogMode hostLogMode);

		/// <summary>Reports content of the host logger to user.</summary>
		/// <param name="logger">The host logger.</param>
		/// <param name="summary">The summary to report.</param>
		protected abstract void ReportHostLogger([NotNull] HostLogger logger, [CanBeNull] Summary summary);

		/// <summary>Reports the execution errors to user.</summary>
		/// <param name="messages">The messages to report.</param>
		/// <param name="competitionState">State of the run.</param>
		protected abstract void ReportExecutionErrors([NotNull] string messages, [NotNull] CompetitionState competitionState);

		/// <summary>Reports failed assertions to user.</summary>
		/// <param name="messages">The messages to report.</param>
		/// <param name="competitionState">State of the run.</param>
		protected abstract void ReportAssertionsFailed([NotNull] string messages, [NotNull] CompetitionState competitionState);

		/// <summary>Reports warnings to user.</summary>
		/// <param name="messages">The messages to report.</param>
		/// <param name="competitionState">State of the run.</param>
		protected abstract void ReportWarnings([NotNull] string messages, [NotNull] CompetitionState competitionState);
		#endregion

		#region Create benchark config
		private ICompetitionConfig PrepareCompetitionConfig(Type benchmarkType, ICompetitionConfig competitionConfig)
		{
			competitionConfig = GetFirstConfig(benchmarkType, competitionConfig);

			var result = new ManualCompetitionConfig(competitionConfig)
			{
				CompetitionMode = OverrideCompetitionMode(competitionConfig)
			};

			return result.AsReadOnly();
		}

		private IConfig CreateBenchmarkConfig(ICompetitionConfig competitionConfig)
		{
			// ReSharper disable once UseObjectOrCollectionInitializer
			var result = new ManualConfig();

			// TODO: to overridable methods?
			result.KeepBenchmarkFiles = competitionConfig.KeepBenchmarkFiles;
			result.UnionRule = competitionConfig.UnionRule;
			result.Set(competitionConfig.GetOrderProvider());

			result.Add(OverrideExporters(competitionConfig).ToArray());
			result.Add(OverrideDiagnosers(competitionConfig).ToArray());

			result.Add(GetJobs(competitionConfig).ToArray());
			result.Add(GetLoggers(competitionConfig).ToArray());
			result.Add(GetColumnProviders(competitionConfig).ToArray());
			result.Add(GetValidators(competitionConfig).ToArray());
			result.Add(GetAnalysers(competitionConfig).ToArray());

			return result.AsReadOnly();
		}

		private List<Job> GetJobs(ICompetitionConfig competitionConfig)
		{
			var result = OverrideJobs(competitionConfig);
			if (result.Count == 0)
			{
				result.Add(CompetitionHelpers.CreateDefaultJob());
			}

			var customToolchain = new InfrastructureMode
			{
				Toolchain = InProcessToolchain.Instance
			};

			for (int i = 0; i < result.Count; i++)
			{
				if (result[i].Infrastructure.Job == null)
				{
					result[i] = result[i].Apply(customToolchain);
				}
				result[i].Freeze();
			}

			return result;
		}

		private List<ILogger> GetLoggers(ICompetitionConfig competitionConfig)
		{
			var result = OverrideLoggers(competitionConfig);

			var runMode = competitionConfig.CompetitionMode.RunMode;
			var hostLogMode = runMode.DetailedLogging ? HostLogMode.AllMessages : HostLogMode.PrefixedOnly;
			result.Insert(0, CreateHostLogger(hostLogMode));

			return result;
		}

		private List<IColumnProvider> GetColumnProviders(ICompetitionConfig competitionConfig)
		{
			// TODO: better columns.
			// TODO: custom column provider?
			var result = OverrideColumns(competitionConfig);

			var limitsMode = competitionConfig.CompetitionMode.Limits;
			result.AddRange(
				new[]
				{
					new SimpleColumnProvider(
						StatisticColumn.Min,
						new CompetitionLimitColumn(limitsMode.LimitProvider, false),
						new CompetitionLimitColumn(limitsMode.LimitProvider, true),
						StatisticColumn.Max)
				});

			return result;
		}

		private List<IValidator> GetValidators(ICompetitionConfig competitionConfig)
		{
			var result = OverrideValidators(competitionConfig);

			var competitionMode = competitionConfig.CompetitionMode;
			bool debugMode = competitionMode.RunMode.AllowDebugBuilds;

			bool customToolchain = competitionConfig.GetJobs().Any(j => !(j.Infrastructure?.Toolchain is InProcessToolchain));
			if (!customToolchain &&
				!result.Any(v => v is InProcessValidator))
			{
				result.Insert(0, debugMode ? InProcessValidator.DontFailOnError : InProcessValidator.FailOnError);
			}

			if (debugMode)
			{
				result.RemoveAll(v => v is JitOptimizationsValidator && v.TreatsWarningsAsErrors);
			}
			else if (competitionMode.SourceAnnotations.UpdateSources &&
				!result.OfType<JitOptimizationsValidator>().Any())
			{
				result.Insert(0, JitOptimizationsValidator.FailOnError);
			}

			Code.BugIf(
				result.OfType<RunStateSlots>().Any(),
				"The config validators should not contain instances of RunStateSlots.");

			// DONTTOUCH: the RunStateSlots should be first in the chain.
			result.Insert(0, new RunStateSlots());

			return result;
		}

		private List<IAnalyser> GetAnalysers(ICompetitionConfig competitionConfig)
		{
			var result = OverrideAnalysers(competitionConfig);

			Code.BugIf(
				result.OfType<CompetitionAnalyser>().Any(),
				"The config analysers should not contain instances of CompetitionAnalyser.");

			// DONTTOUCH: the CompetitionAnnotateAnalyser should be last analyser in the chain.
			result.Add(GetCompetitionAnalyser(competitionConfig));

			return result;
		}

		private CompetitionAnalyser GetCompetitionAnalyser(ICompetitionConfig competitionConfig)
		{
			var annotationsMode = competitionConfig.CompetitionMode.SourceAnnotations;

			return annotationsMode.UpdateSources
				? new CompetitionAnnotateAnalyser()
				: new CompetitionAnalyser();
		}

		#region Override config parameters
		/// <summary>Override competition mode.</summary>
		/// <param name="competitionConfig">The competition mode.</param>
		/// <returns>Parameters for the competition</returns>
		[NotNull]
		protected virtual CompetitionMode OverrideCompetitionMode([NotNull] ICompetitionConfig competitionConfig) =>
			competitionConfig.CompetitionMode??CompetitionMode.Default;

		/// <summary>Override competition jobs.</summary>
		/// <param name="competitionConfig">The competition config.</param>
		/// <returns>The jobs for the competition</returns>
		protected virtual List<Job> OverrideJobs([NotNull] ICompetitionConfig competitionConfig) =>
			competitionConfig.GetJobs().ToList();

		/// <summary>Override competition exporters.</summary>
		/// <param name="competitionConfig">The competition config.</param>
		/// <returns>The jobs for the competition</returns>
		protected virtual List<IExporter> OverrideExporters([NotNull] ICompetitionConfig competitionConfig) =>
			competitionConfig.GetExporters().ToList();

		/// <summary>Override competition diagnosers.</summary>
		/// <param name="competitionConfig">The competition config.</param>
		/// <returns>The diagnosers for the competition</returns>
		protected virtual List<IDiagnoser> OverrideDiagnosers([NotNull] ICompetitionConfig competitionConfig) =>
			competitionConfig.GetDiagnosers().ToList();

		/// <summary>Override competition loggers.</summary>
		/// <param name="competitionConfig">The competition config.</param>
		/// <returns>The loggers for the competition</returns>
		protected virtual List<ILogger> OverrideLoggers([NotNull] ICompetitionConfig competitionConfig) =>
			competitionConfig.GetLoggers().ToList();

		/// <summary>Override competition columns.</summary>
		/// <param name="competitionConfig">The competition config.</param>
		/// <returns>The columns for the competition</returns>
		protected virtual List<IColumnProvider> OverrideColumns([NotNull] ICompetitionConfig competitionConfig) =>
			competitionConfig.GetColumnProviders().ToList();

		/// <summary>Override competition validators.</summary>
		/// <param name="competitionConfig">The competition config.</param>
		/// <returns>The validators for the competition</returns>
		protected virtual List<IValidator> OverrideValidators([NotNull] ICompetitionConfig competitionConfig) =>
			competitionConfig.GetValidators().ToList();

		/// <summary>Override competition analysers.</summary>
		/// <param name="competitionConfig">The competition config.</param>
		/// <returns>The analysers for the competition</returns>
		protected virtual List<IAnalyser> OverrideAnalysers([NotNull] ICompetitionConfig competitionConfig) =>
			competitionConfig.GetAnalysers().ToList();
		#endregion

		#endregion

		#region Messages
		private void ReportMessagesToUser(
			[NotNull] ICompetitionConfig competitionConfig,
			[NotNull] CompetitionState competitionState)
		{
			var criticalErrorMessages = GetMessageLines(
				competitionState, m => m.MessageSeverity > MessageSeverity.TestError, true);
			bool hasCriticalMessages = criticalErrorMessages.Any();

			var testFailedMessages = GetMessageLines(
				competitionState, m => m.MessageSeverity == MessageSeverity.TestError, hasCriticalMessages);
			bool hasTestFailedMessages = testFailedMessages.Any();

			var warningMessages = GetMessageLines(
				competitionState, m => m.MessageSeverity == MessageSeverity.Warning, true);
			bool hasWarnings = warningMessages.Any();

			var infoMessages = GetMessageLines(competitionState, m => m.MessageSeverity < MessageSeverity.Warning, true);
			bool hasInfo = infoMessages.Any();

			if (!(hasCriticalMessages || hasTestFailedMessages || hasWarnings))
				return;

			var allMessages = new List<string>();

			// TODO: simplify
			if (hasCriticalMessages)
			{
				allMessages.Add("Test completed with errors, details below.");
			}
			else if (hasTestFailedMessages)
			{
				allMessages.Add("Test failed, details below.");
			}
			else
			{
				allMessages.Add("Test completed with warnings, details below.");
			}

			if (hasCriticalMessages)
			{
				allMessages.Add("Errors:");
				allMessages.AddRange(criticalErrorMessages);
			}
			if (hasTestFailedMessages)
			{
				allMessages.Add("Failed assertions:");
				allMessages.AddRange(testFailedMessages);
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

			var messageText = string.Join(Environment.NewLine, allMessages);
			var runMode = competitionConfig.CompetitionMode.RunMode;
			if (hasCriticalMessages)
			{
				ReportExecutionErrors(messageText, competitionState);
			}
			else if (hasTestFailedMessages || runMode.ReportWarningsAsErrors)
			{
				ReportAssertionsFailed(messageText, competitionState);
			}
			else
			{
				ReportWarnings(messageText, competitionState);
			}
		}

		private string[] GetMessageLines(
			CompetitionState competitionState,
			Func<IMessage, bool> severityFilter,
			bool fromAllRuns)
		{
			var result = from message in competitionState.GetMessages()
						 where severityFilter(message) && ShouldReport(message, competitionState.RunNumber, fromAllRuns)
						 orderby message.RunNumber, message.RunMessageNumber
						 select $"    * Run #{message.RunNumber}: {message.MessageText}";

			return result.ToArray();
		}

		private bool ShouldReport(IMessage message, int runNumber, bool fromAllRuns)
		{
			if (fromAllRuns || message.RunNumber == runNumber)
				return true;

			// all of these on last run only.
			switch (message.MessageSource)
			{
				case MessageSource.Validator:
				case MessageSource.Analyser:
				case MessageSource.Diagnoser:
					return false;
				default:
					return true;
			}
		}
		#endregion
	}
}