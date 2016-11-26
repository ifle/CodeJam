﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace CodeJam
{
	public abstract class OneOf<T1, T2>
	{
		public abstract TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func);

		public abstract void Do(Action<T1> case1Action, Action<T2> case2Action);

		private sealed class Case1 : OneOf<T1, T2>
		{
			private T1 _value;

			public Case1(T1 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func) => case1Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action) => case1Action(_value);
		}

		public OneOf<T1, T2> Create(T1 value) => new Case1(value);

		private sealed class Case2 : OneOf<T1, T2>
		{
			private T2 _value;

			public Case2(T2 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func) => case2Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action) => case2Action(_value);
		}

		public OneOf<T1, T2> Create(T2 value) => new Case2(value);

	}

	public abstract class OneOf<T1, T2, T3>
	{
		public abstract TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func);

		public abstract void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action);

		private sealed class Case1 : OneOf<T1, T2, T3>
		{
			private T1 _value;

			public Case1(T1 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func) => case1Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action) => case1Action(_value);
		}

		public OneOf<T1, T2, T3> Create(T1 value) => new Case1(value);

		private sealed class Case2 : OneOf<T1, T2, T3>
		{
			private T2 _value;

			public Case2(T2 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func) => case2Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action) => case2Action(_value);
		}

		public OneOf<T1, T2, T3> Create(T2 value) => new Case2(value);

		private sealed class Case3 : OneOf<T1, T2, T3>
		{
			private T3 _value;

			public Case3(T3 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func) => case3Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action) => case3Action(_value);
		}

		public OneOf<T1, T2, T3> Create(T3 value) => new Case3(value);

	}

	public abstract class OneOf<T1, T2, T3, T4>
	{
		public abstract TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func);

		public abstract void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action);

		private sealed class Case1 : OneOf<T1, T2, T3, T4>
		{
			private T1 _value;

			public Case1(T1 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func) => case1Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action) => case1Action(_value);
		}

		public OneOf<T1, T2, T3, T4> Create(T1 value) => new Case1(value);

		private sealed class Case2 : OneOf<T1, T2, T3, T4>
		{
			private T2 _value;

			public Case2(T2 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func) => case2Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action) => case2Action(_value);
		}

		public OneOf<T1, T2, T3, T4> Create(T2 value) => new Case2(value);

		private sealed class Case3 : OneOf<T1, T2, T3, T4>
		{
			private T3 _value;

			public Case3(T3 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func) => case3Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action) => case3Action(_value);
		}

		public OneOf<T1, T2, T3, T4> Create(T3 value) => new Case3(value);

		private sealed class Case4 : OneOf<T1, T2, T3, T4>
		{
			private T4 _value;

			public Case4(T4 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func) => case4Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action) => case4Action(_value);
		}

		public OneOf<T1, T2, T3, T4> Create(T4 value) => new Case4(value);

	}

	public abstract class OneOf<T1, T2, T3, T4, T5>
	{
		public abstract TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func);

		public abstract void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action);

		private sealed class Case1 : OneOf<T1, T2, T3, T4, T5>
		{
			private T1 _value;

			public Case1(T1 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func) => case1Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action) => case1Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5> Create(T1 value) => new Case1(value);

		private sealed class Case2 : OneOf<T1, T2, T3, T4, T5>
		{
			private T2 _value;

			public Case2(T2 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func) => case2Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action) => case2Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5> Create(T2 value) => new Case2(value);

		private sealed class Case3 : OneOf<T1, T2, T3, T4, T5>
		{
			private T3 _value;

			public Case3(T3 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func) => case3Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action) => case3Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5> Create(T3 value) => new Case3(value);

		private sealed class Case4 : OneOf<T1, T2, T3, T4, T5>
		{
			private T4 _value;

			public Case4(T4 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func) => case4Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action) => case4Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5> Create(T4 value) => new Case4(value);

		private sealed class Case5 : OneOf<T1, T2, T3, T4, T5>
		{
			private T5 _value;

			public Case5(T5 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func) => case5Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action) => case5Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5> Create(T5 value) => new Case5(value);

	}

	public abstract class OneOf<T1, T2, T3, T4, T5, T6>
	{
		public abstract TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func);

		public abstract void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action);

		private sealed class Case1 : OneOf<T1, T2, T3, T4, T5, T6>
		{
			private T1 _value;

			public Case1(T1 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func) => case1Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action) => case1Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6> Create(T1 value) => new Case1(value);

		private sealed class Case2 : OneOf<T1, T2, T3, T4, T5, T6>
		{
			private T2 _value;

			public Case2(T2 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func) => case2Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action) => case2Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6> Create(T2 value) => new Case2(value);

		private sealed class Case3 : OneOf<T1, T2, T3, T4, T5, T6>
		{
			private T3 _value;

			public Case3(T3 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func) => case3Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action) => case3Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6> Create(T3 value) => new Case3(value);

		private sealed class Case4 : OneOf<T1, T2, T3, T4, T5, T6>
		{
			private T4 _value;

			public Case4(T4 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func) => case4Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action) => case4Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6> Create(T4 value) => new Case4(value);

		private sealed class Case5 : OneOf<T1, T2, T3, T4, T5, T6>
		{
			private T5 _value;

			public Case5(T5 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func) => case5Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action) => case5Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6> Create(T5 value) => new Case5(value);

		private sealed class Case6 : OneOf<T1, T2, T3, T4, T5, T6>
		{
			private T6 _value;

			public Case6(T6 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func) => case6Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action) => case6Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6> Create(T6 value) => new Case6(value);

	}

	public abstract class OneOf<T1, T2, T3, T4, T5, T6, T7>
	{
		public abstract TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func);

		public abstract void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action);

		private sealed class Case1 : OneOf<T1, T2, T3, T4, T5, T6, T7>
		{
			private T1 _value;

			public Case1(T1 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func) => case1Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action) => case1Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7> Create(T1 value) => new Case1(value);

		private sealed class Case2 : OneOf<T1, T2, T3, T4, T5, T6, T7>
		{
			private T2 _value;

			public Case2(T2 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func) => case2Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action) => case2Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7> Create(T2 value) => new Case2(value);

		private sealed class Case3 : OneOf<T1, T2, T3, T4, T5, T6, T7>
		{
			private T3 _value;

			public Case3(T3 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func) => case3Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action) => case3Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7> Create(T3 value) => new Case3(value);

		private sealed class Case4 : OneOf<T1, T2, T3, T4, T5, T6, T7>
		{
			private T4 _value;

			public Case4(T4 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func) => case4Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action) => case4Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7> Create(T4 value) => new Case4(value);

		private sealed class Case5 : OneOf<T1, T2, T3, T4, T5, T6, T7>
		{
			private T5 _value;

			public Case5(T5 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func) => case5Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action) => case5Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7> Create(T5 value) => new Case5(value);

		private sealed class Case6 : OneOf<T1, T2, T3, T4, T5, T6, T7>
		{
			private T6 _value;

			public Case6(T6 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func) => case6Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action) => case6Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7> Create(T6 value) => new Case6(value);

		private sealed class Case7 : OneOf<T1, T2, T3, T4, T5, T6, T7>
		{
			private T7 _value;

			public Case7(T7 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func) => case7Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action) => case7Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7> Create(T7 value) => new Case7(value);

	}

	public abstract class OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		public abstract TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func);

		public abstract void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action);

		private sealed class Case1 : OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			private T1 _value;

			public Case1(T1 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func) => case1Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action) => case1Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7, T8> Create(T1 value) => new Case1(value);

		private sealed class Case2 : OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			private T2 _value;

			public Case2(T2 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func) => case2Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action) => case2Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7, T8> Create(T2 value) => new Case2(value);

		private sealed class Case3 : OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			private T3 _value;

			public Case3(T3 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func) => case3Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action) => case3Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7, T8> Create(T3 value) => new Case3(value);

		private sealed class Case4 : OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			private T4 _value;

			public Case4(T4 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func) => case4Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action) => case4Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7, T8> Create(T4 value) => new Case4(value);

		private sealed class Case5 : OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			private T5 _value;

			public Case5(T5 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func) => case5Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action) => case5Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7, T8> Create(T5 value) => new Case5(value);

		private sealed class Case6 : OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			private T6 _value;

			public Case6(T6 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func) => case6Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action) => case6Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7, T8> Create(T6 value) => new Case6(value);

		private sealed class Case7 : OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			private T7 _value;

			public Case7(T7 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func) => case7Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action) => case7Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7, T8> Create(T7 value) => new Case7(value);

		private sealed class Case8 : OneOf<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			private T8 _value;

			public Case8(T8 value)
			{
				_value = value;
			}

			public override TResult Match<TResult>(Func<T1, TResult> case1Func, Func<T2, TResult> case2Func, Func<T3, TResult> case3Func, Func<T4, TResult> case4Func, Func<T5, TResult> case5Func, Func<T6, TResult> case6Func, Func<T7, TResult> case7Func, Func<T8, TResult> case8Func) => case8Func(_value);

			public override void Do(Action<T1> case1Action, Action<T2> case2Action, Action<T3> case3Action, Action<T4> case4Action, Action<T5> case5Action, Action<T6> case6Action, Action<T7> case7Action, Action<T8> case8Action) => case8Action(_value);
		}

		public OneOf<T1, T2, T3, T4, T5, T6, T7, T8> Create(T8 value) => new Case8(value);

	}

}