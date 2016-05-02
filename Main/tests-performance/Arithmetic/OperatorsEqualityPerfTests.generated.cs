﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using BenchmarkDotNet.NUnit;

using NUnit.Framework;

using static CodeJam.AssemblyWideConfig;

namespace CodeJam.Arithmetic
{
	[TestFixture(Category = PerfTestsConstants.PerfTestCategory + ": Operators<T>, equality")]
	[CompetitionMetadata("CodeJam.Arithmetic.OperatorsEqualityPerfTests.generated.xml")]
	[Explicit(PerfTestsConstants.ExplicitExcludeReason)]
	public class OperatorsEqualityPerfTests
	{
		#region AreEqual
		[Test]
		public void RunIntAreEqualCase() =>
			CompetitionBenchmarkRunner.Run<IntAreEqualCase>(RunConfig);

		public class IntAreEqualCase : IntOperatorsBaseCase
		{
			private static readonly Func<int, int, bool> _opAreEqual = Operators<int>.AreEqual;
			private static readonly Func<int, int, bool> _emittedAreEqual = (a, b) => a == b;
			private static readonly Comparer<int> _comparer = Comparer<int>.Default;
			private static readonly EqualityComparer<int> _eqComparer = EqualityComparer<int>.Default;

			[CompetitionBaseline]
			public bool Test00AreEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a == b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) == 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]);
				return result;
			}
		}

		[Test]
		public void RunNullableIntAreEqualCase() =>
			CompetitionBenchmarkRunner.Run<NullableIntAreEqualCase>(RunConfig);

		public class NullableIntAreEqualCase : NullableIntOperatorsBaseCase
		{
			private static readonly Func<int?, int?, bool> _opAreEqual = Operators<int?>.AreEqual;
			private static readonly Func<int?, int?, bool> _emittedAreEqual = (a, b) => a == b;
			private static readonly Comparer<int?> _comparer = Comparer<int?>.Default;
			private static readonly EqualityComparer<int?> _eqComparer = EqualityComparer<int?>.Default;

			[CompetitionBaseline]
			public bool Test00AreEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a == b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) == 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]);
				return result;
			}
		}

		[Test]
		public void RunEnumAreEqualCase() =>
			CompetitionBenchmarkRunner.Run<EnumAreEqualCase>(RunConfig);

		public class EnumAreEqualCase : EnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _opAreEqual = Operators<AttributeTargets>.AreEqual;
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _emittedAreEqual = (a, b) => a == b;
			private static readonly Comparer<AttributeTargets> _comparer = Comparer<AttributeTargets>.Default;
			private static readonly EqualityComparer<AttributeTargets> _eqComparer = EqualityComparer<AttributeTargets>.Default;

			[CompetitionBaseline]
			public bool Test00AreEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a == b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) == 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]);
				return result;
			}
		}

		[Test]
		public void RunNullableEnumAreEqualCase() =>
			CompetitionBenchmarkRunner.Run<NullableEnumAreEqualCase>(RunConfig);

		public class NullableEnumAreEqualCase : NullableEnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _opAreEqual = Operators<AttributeTargets?>.AreEqual;
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _emittedAreEqual = (a, b) => a == b;
			private static readonly Comparer<AttributeTargets?> _comparer = Comparer<AttributeTargets?>.Default;
			private static readonly EqualityComparer<AttributeTargets?> _eqComparer = EqualityComparer<AttributeTargets?>.Default;

			[CompetitionBaseline]
			public bool Test00AreEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a == b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) == 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]);
				return result;
			}
		}

		[Test]
		public void RunNullableDateTimeAreEqualCase() =>
			CompetitionBenchmarkRunner.Run<NullableDateTimeAreEqualCase>(RunConfig);

		public class NullableDateTimeAreEqualCase : NullableDateTimeOperatorsBaseCase
		{
			private static readonly Func<DateTime?, DateTime?, bool> _opAreEqual = Operators<DateTime?>.AreEqual;
			private static readonly Func<DateTime?, DateTime?, bool> _emittedAreEqual = (a, b) => a == b;
			private static readonly Comparer<DateTime?> _comparer = Comparer<DateTime?>.Default;
			private static readonly EqualityComparer<DateTime?> _eqComparer = EqualityComparer<DateTime?>.Default;

			[CompetitionBaseline]
			public bool Test00AreEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a == b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) == 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]);
				return result;
			}
		}

		[Test]
		public void RunStringAreEqualCase() =>
			CompetitionBenchmarkRunner.Run<StringAreEqualCase>(RunConfig);

		public class StringAreEqualCase : StringOperatorsBaseCase
		{
			private static readonly Func<string, string, bool> _opAreEqual = Operators<string>.AreEqual;
			private static readonly Func<string, string, bool> _emittedAreEqual = (a, b) => a == b;
			private static readonly Comparer<string> _comparer = Comparer<string>.Default;
			private static readonly EqualityComparer<string> _eqComparer = EqualityComparer<string>.Default;

			[CompetitionBaseline]
			public bool Test00AreEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a == b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) == 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]);
				return result;
			}
		}
		#endregion

		#region AreNotEqual
		[Test]
		public void RunIntAreNotEqualCase() =>
			CompetitionBenchmarkRunner.Run<IntAreNotEqualCase>(RunConfig);

		public class IntAreNotEqualCase : IntOperatorsBaseCase
		{
			private static readonly Func<int, int, bool> _opAreNotEqual = Operators<int>.AreNotEqual;
			private static readonly Func<int, int, bool> _emittedAreNotEqual = (a, b) => a != b;
			private static readonly Comparer<int> _comparer = Comparer<int>.Default;
			private static readonly EqualityComparer<int> _eqComparer = EqualityComparer<int>.Default;

			[CompetitionBaseline]
			public bool Test00AreNotEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a != b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreNotEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreNotEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) != 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]) == false;
				return result;
			}
		}

		[Test]
		public void RunNullableIntAreNotEqualCase() =>
			CompetitionBenchmarkRunner.Run<NullableIntAreNotEqualCase>(RunConfig);

		public class NullableIntAreNotEqualCase : NullableIntOperatorsBaseCase
		{
			private static readonly Func<int?, int?, bool> _opAreNotEqual = Operators<int?>.AreNotEqual;
			private static readonly Func<int?, int?, bool> _emittedAreNotEqual = (a, b) => a != b;
			private static readonly Comparer<int?> _comparer = Comparer<int?>.Default;
			private static readonly EqualityComparer<int?> _eqComparer = EqualityComparer<int?>.Default;

			[CompetitionBaseline]
			public bool Test00AreNotEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a != b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreNotEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreNotEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) != 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]) == false;
				return result;
			}
		}

		[Test]
		public void RunEnumAreNotEqualCase() =>
			CompetitionBenchmarkRunner.Run<EnumAreNotEqualCase>(RunConfig);

		public class EnumAreNotEqualCase : EnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _opAreNotEqual = Operators<AttributeTargets>.AreNotEqual;
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _emittedAreNotEqual = (a, b) => a != b;
			private static readonly Comparer<AttributeTargets> _comparer = Comparer<AttributeTargets>.Default;
			private static readonly EqualityComparer<AttributeTargets> _eqComparer = EqualityComparer<AttributeTargets>.Default;

			[CompetitionBaseline]
			public bool Test00AreNotEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a != b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreNotEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreNotEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) != 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]) == false;
				return result;
			}
		}

		[Test]
		public void RunNullableEnumAreNotEqualCase() =>
			CompetitionBenchmarkRunner.Run<NullableEnumAreNotEqualCase>(RunConfig);

		public class NullableEnumAreNotEqualCase : NullableEnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _opAreNotEqual = Operators<AttributeTargets?>.AreNotEqual;
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _emittedAreNotEqual = (a, b) => a != b;
			private static readonly Comparer<AttributeTargets?> _comparer = Comparer<AttributeTargets?>.Default;
			private static readonly EqualityComparer<AttributeTargets?> _eqComparer = EqualityComparer<AttributeTargets?>.Default;

			[CompetitionBaseline]
			public bool Test00AreNotEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a != b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreNotEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreNotEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) != 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]) == false;
				return result;
			}
		}

		[Test]
		public void RunNullableDateTimeAreNotEqualCase() =>
			CompetitionBenchmarkRunner.Run<NullableDateTimeAreNotEqualCase>(RunConfig);

		public class NullableDateTimeAreNotEqualCase : NullableDateTimeOperatorsBaseCase
		{
			private static readonly Func<DateTime?, DateTime?, bool> _opAreNotEqual = Operators<DateTime?>.AreNotEqual;
			private static readonly Func<DateTime?, DateTime?, bool> _emittedAreNotEqual = (a, b) => a != b;
			private static readonly Comparer<DateTime?> _comparer = Comparer<DateTime?>.Default;
			private static readonly EqualityComparer<DateTime?> _eqComparer = EqualityComparer<DateTime?>.Default;

			[CompetitionBaseline]
			public bool Test00AreNotEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a != b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreNotEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreNotEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) != 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]) == false;
				return result;
			}
		}

		[Test]
		public void RunStringAreNotEqualCase() =>
			CompetitionBenchmarkRunner.Run<StringAreNotEqualCase>(RunConfig);

		public class StringAreNotEqualCase : StringOperatorsBaseCase
		{
			private static readonly Func<string, string, bool> _opAreNotEqual = Operators<string>.AreNotEqual;
			private static readonly Func<string, string, bool> _emittedAreNotEqual = (a, b) => a != b;
			private static readonly Comparer<string> _comparer = Comparer<string>.Default;
			private static readonly EqualityComparer<string> _eqComparer = EqualityComparer<string>.Default;

			[CompetitionBaseline]
			public bool Test00AreNotEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a != b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01AreNotEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02AreNotEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedAreNotEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i]) != 0;
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03EqualityComparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _eqComparer.Equals(ValuesA[i], ValuesB[i]) == false;
				return result;
			}
		}
		#endregion
	}
}