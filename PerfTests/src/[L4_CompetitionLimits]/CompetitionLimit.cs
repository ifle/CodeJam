﻿using System;

using BenchmarkDotNet.Helpers;

using JetBrains.Annotations;

namespace CodeJam.PerfTests
{
	/// <summary>
	/// Class that describes limits for benchmarks participating in competition.
	/// </summary>
	[PublicAPI]
	public class CompetitionLimit
	{
		#region Static members
		/// <summary>Empty value for the competition limit.</summary>
		public const int EmptyValue = 0;

		/// <summary>Ignored value for the competition limit..</summary>
		public const int IgnoreValue = -1;

		/// <summary>Default format for ratio (relative) limits.</summary>
		public const string RatioFormat = "0.00";

		/// <summary>Default format for actual value for ratio (relative) limits.</summary>
		public const string ActualRatioFormat = "0.000";

		/// <summary>Returns string representation for the actual ratio (relative) value.</summary>
		/// <param name="actualRatio">The actual ratio (relative) value.</param>
		/// <returns>String representation for actual ratio.</returns>
		public static string GetActualRatioText(double actualRatio) =>
			actualRatio.ToString(ActualRatioFormat, EnvironmentInfo.MainCultureInfo);

		#region Core logic for competition limits
		[AssertionMethod]
		private static void AssertLimitArgument(double value, [InvokerParameterName] string argName)
		{
			if (IsInvalidValue(value))
			{
				throw CodeExceptions.Argument(argName, $"The {argName} value ({value}) should be a finite number.");
			}
		}

		private static double AdjustLimitArgument(double value, [InvokerParameterName] string argName)
		{
			AssertLimitArgument(value, argName);

			return IsIgnoredValue(value) ? IgnoreValue : value;
		}

		private static bool IsInvalidValue(double value) => double.IsInfinity(value) || double.IsNaN(value);

		private static bool IsIgnoredValue(double value) => value < EmptyValue;

		// ReSharper disable once CompareOfFloatsByEqualityOperator
		private static bool IsEmptyValue(double value) => value == EmptyValue;
		#endregion

		#region Limit helper methods (reusable methods for memory and timing limits)
		/// <summary>
		/// Helper method for checking the value against min limit.
		/// </summary>
		/// <param name="minLimit">The limit.</param>
		/// <param name="value">The value to check.</param>
		/// <returns><c>true</c> if the value fits into limit.</returns>
		protected bool IsMinLimitOk(double minLimit, double value)
		{
			AssertLimitArgument(minLimit, nameof(minLimit));

			if (IsInvalidValue(value) || IsIgnoredValue(value) || IsEmptyValue(value))
				return true;

			if (IsIgnoredValue(minLimit))
				return true;

			if (IsEmptyValue(minLimit))
				return false;

			return value >= minLimit;
		}

		/// <summary>
		/// Helper method for checking the value against max limit.
		/// </summary>
		/// <param name="maxLimit">The limit.</param>
		/// <param name="value">The value to check.</param>
		/// <returns><c>true</c> if the value fits into limit.</returns>
		protected bool IsMaxLimitOk(double maxLimit, double value)
		{
			AssertLimitArgument(maxLimit, nameof(maxLimit));

			if (IsInvalidValue(value) || IsIgnoredValue(value) || IsEmptyValue(value))
				return true;

			if (IsIgnoredValue(maxLimit))
				return true;

			if (IsEmptyValue(maxLimit))
				return false;

			return value <= maxLimit;
		}

		/// <summary>
		/// Helper method for checking before extending the min limit.
		/// IMPORTANT: DO NOT replace with call to <seealso cref="IsMinLimitOk"/>.
		/// Implementation may change in the future.
		/// </summary>
		/// <param name="minLimit">The minimum limit.</param>
		/// <param name="newMinLimit">The new minimum limit.</param>
		/// <returns><c>true</c> if the current limit should be replaced with new one.</returns>
		protected bool ShouldBeUpdatedMin(double minLimit, double newMinLimit) =>
			!IsMinLimitOk(minLimit, newMinLimit);

		/// <summary>
		/// Helper method for checking before extending the max limit.
		/// IMPORTANT: DO NOT replace with call to <seealso cref="IsMaxLimitOk"/>.
		/// Implementation may change in the future.
		/// </summary>
		/// <param name="maxLimit">The maximum limit.</param>
		/// <param name="newMaxLimit">The new maximum limit.</param>
		/// <returns><c>true</c> if the current limit should be replaced with new one.</returns>
		protected bool ShouldBeUpdatedMax(double maxLimit, double newMaxLimit) =>
			!IsMaxLimitOk(maxLimit, newMaxLimit);
		#endregion

		/// <summary>The empty competition limit.</summary>
		public static readonly CompetitionLimit Empty = new CompetitionLimit(EmptyValue, EmptyValue);

		/// <summary>The ignored (will not be checked) competition limit.</summary>
		public static readonly CompetitionLimit Ignored = new CompetitionLimit(IgnoreValue, IgnoreValue);
		#endregion

		/// <summary>Initializes a new instance of the <see cref="CompetitionLimit"/> class.</summary>
		/// <param name="minRatio">The minimum timing ratio relative to the baseline.</param>
		/// <param name="maxRatio">The maximum timing ratio relative to the baseline.</param>
		public CompetitionLimit(
			double minRatio, double maxRatio)
		{
			minRatio = AdjustLimitArgument(minRatio, nameof(minRatio));
			maxRatio = AdjustLimitArgument(maxRatio, nameof(maxRatio));

			if (!IsMinLimitOk(minRatio, maxRatio))
			{
				throw CodeExceptions.Argument(
					nameof(maxRatio),
					$"{nameof(maxRatio)} should be greater than or equal to {nameof(minRatio)}");
			}

			MinRatio = minRatio;
			MaxRatio = maxRatio;
		}

		/// <summary>All limits are is empty.</summary>
		/// <value><c>true</c> if all limits are is empty; otherwise, <c>false</c>.</value>
		public bool IsEmpty => IsEmptyValue(MinRatio) && IsEmptyValue(MaxRatio);

		/// <summary>All limits are ignored.</summary>
		/// <value><c>true</c> if all limits are ignored; otherwise, <c>false</c>.</value>
		public bool IgnoreAll => IgnoreMinRatio && IgnoreMaxRatio;

		/// <summary>The minimum timing ratio relative to the baseline.</summary>
		/// <value>The minimum timing ratio relative to the baseline.</value>
		public double MinRatio { get; protected set; }

		/// <summary>The maximum timing ratio relative to the baseline.</summary>
		/// <value>The maximum timing ratio relative to the baseline.</value>
		public double MaxRatio { get; protected set; }

		/// <summary>The minimum timing ratio limit is ignored.</summary>
		/// <value><c>true</c> if the minimum timing ratio limit is ignored; otherwise, <c>false</c>.</value>
		public bool IgnoreMinRatio => IsIgnoredValue(MinRatio);

		/// <summary>The maximum timing ratio limit is ignored.</summary>
		/// <value><c>true</c> if the maximum timing ratio limit is ignored; otherwise, <c>false</c>.</value>
		public bool IgnoreMaxRatio => IsIgnoredValue(MaxRatio);

		/// <summary>The the value fits into minimum timing ratio limit.</summary>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if the the value fits into minimum timing ratio limit.</returns>
		public bool MinRatioIsOk(double value) => IsMinLimitOk(MinRatio, value);

		/// <summary>The the value fits into maximum timing ratio limit.</summary>
		/// <param name="value">The value.</param>
		/// <returns><c>true</c> if the the value fits into maximum timing ratio limit.</returns>
		public bool MaxRatioIsOk(double value) => IsMaxLimitOk(MaxRatio, value);

		/// <summary>The string representation of minimum timing ratio limit.</summary>
		/// <value>The string representation of minimum timing ratio limit.</value>
		public string MinRatioText => IgnoreMinRatio
			? MinRatio.ToString(EnvironmentInfo.MainCultureInfo)
			: MinRatio.ToString(RatioFormat, EnvironmentInfo.MainCultureInfo);

		/// <summary>The string representation of maximum timing ratio limit.</summary>
		/// <value>The string representation of maximum timing ratio limit.</value>
		public string MaxRatioText => IgnoreMaxRatio
			? MaxRatio.ToString(EnvironmentInfo.MainCultureInfo)
			: MaxRatio.ToString(RatioFormat, EnvironmentInfo.MainCultureInfo);
	}
}