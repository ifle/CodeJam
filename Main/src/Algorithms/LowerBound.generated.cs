﻿using System;
using System.Collections.Generic;

namespace CodeJam
{
	partial class Algorithms
	{

		#region float
		/// <summary>
		/// Returns the minimum index i in the range [0, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<float> list, float value)
			=> list.LowerBound(value, 0);

		/// <summary>
		/// Returns the minimum index i in the range [from, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<float> list, float value, int from)
			=> list.LowerBound(value, from, list.Count);

		/// <summary>
		/// Returns the minimum index i in the range [from, to - 1] such that list[i] >= value
		/// or "to" if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <param name="to">The upper bound for the index (not included)</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<float> list, float value, int from, int to)
		{
			ValidateIndicesRange(from, to, list.Count);
			while (from < to)
			{
				var median = from + (to - from) / 2;
				if (list[median] >= value)
				{
					to = median;
				}
				else
				{
					from = median + 1;
				}
			}
			return from;
		}
		#endregion

		#region double
		/// <summary>
		/// Returns the minimum index i in the range [0, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<double> list, double value)
			=> list.LowerBound(value, 0);

		/// <summary>
		/// Returns the minimum index i in the range [from, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<double> list, double value, int from)
			=> list.LowerBound(value, from, list.Count);

		/// <summary>
		/// Returns the minimum index i in the range [from, to - 1] such that list[i] >= value
		/// or "to" if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <param name="to">The upper bound for the index (not included)</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<double> list, double value, int from, int to)
		{
			ValidateIndicesRange(from, to, list.Count);
			while (from < to)
			{
				var median = from + (to - from) / 2;
				if (list[median] >= value)
				{
					to = median;
				}
				else
				{
					from = median + 1;
				}
			}
			return from;
		}
		#endregion

		#region TimeSpan
		/// <summary>
		/// Returns the minimum index i in the range [0, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<TimeSpan> list, TimeSpan value)
			=> list.LowerBound(value, 0);

		/// <summary>
		/// Returns the minimum index i in the range [from, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<TimeSpan> list, TimeSpan value, int from)
			=> list.LowerBound(value, from, list.Count);

		/// <summary>
		/// Returns the minimum index i in the range [from, to - 1] such that list[i] >= value
		/// or "to" if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <param name="to">The upper bound for the index (not included)</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<TimeSpan> list, TimeSpan value, int from, int to)
		{
			ValidateIndicesRange(from, to, list.Count);
			while (from < to)
			{
				var median = from + (to - from) / 2;
				if (list[median] >= value)
				{
					to = median;
				}
				else
				{
					from = median + 1;
				}
			}
			return from;
		}
		#endregion

		#region DateTime
		/// <summary>
		/// Returns the minimum index i in the range [0, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<DateTime> list, DateTime value)
			=> list.LowerBound(value, 0);

		/// <summary>
		/// Returns the minimum index i in the range [from, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<DateTime> list, DateTime value, int from)
			=> list.LowerBound(value, from, list.Count);

		/// <summary>
		/// Returns the minimum index i in the range [from, to - 1] such that list[i] >= value
		/// or "to" if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <param name="to">The upper bound for the index (not included)</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<DateTime> list, DateTime value, int from, int to)
		{
			ValidateIndicesRange(from, to, list.Count);
			while (from < to)
			{
				var median = from + (to - from) / 2;
				if (list[median] >= value)
				{
					to = median;
				}
				else
				{
					from = median + 1;
				}
			}
			return from;
		}
		#endregion

		#region DateTimeOffset
		/// <summary>
		/// Returns the minimum index i in the range [0, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<DateTimeOffset> list, DateTimeOffset value)
			=> list.LowerBound(value, 0);

		/// <summary>
		/// Returns the minimum index i in the range [from, list.Count - 1] such that list[i] >= value
		/// or list.Count if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<DateTimeOffset> list, DateTimeOffset value, int from)
			=> list.LowerBound(value, from, list.Count);

		/// <summary>
		/// Returns the minimum index i in the range [from, to - 1] such that list[i] >= value
		/// or "to" if no such i exists
		/// </summary>
		/// <param name="list">The sorted list</param>
		/// <param name="value">The value to compare</param>
		/// <param name="from">The minimum index</param>
		/// <param name="to">The upper bound for the index (not included)</param>
		/// <returns>The lower bound for the value</returns>
		public static int LowerBound(this IList<DateTimeOffset> list, DateTimeOffset value, int from, int to)
		{
			ValidateIndicesRange(from, to, list.Count);
			while (from < to)
			{
				var median = from + (to - from) / 2;
				if (list[median] >= value)
				{
					to = median;
				}
				else
				{
					from = median + 1;
				}
			}
			return from;
		}
		#endregion
	}
}
