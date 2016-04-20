﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using JetBrains.Annotations;

namespace CodeJam
{
	/// <summary>
	/// Provides static methods for creating tuple structs.
	/// </summary>
	[PublicAPI]
	public static class ValueTuple
	{
		/// <summary>
		/// Creates a new 2-tuple.
		/// </summary>
		/// <param name="item1">The value of the component 1 of the tuple.</param>
		/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
		/// <param name="item2">The value of the component 2 of the tuple.</param>
		/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
		/// <returns>A 2-tuple whose value is (item1, item2).</returns>
		public static ValueTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) =>
			new ValueTuple<T1, T2>(item1, item2);

		/// <summary>
		/// Creates a new 3-tuple.
		/// </summary>
		/// <param name="item1">The value of the component 1 of the tuple.</param>
		/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
		/// <param name="item2">The value of the component 2 of the tuple.</param>
		/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
		/// <param name="item3">The value of the component 3 of the tuple.</param>
		/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
		/// <returns>A 3-tuple whose value is (item1, item2).</returns>
		public static ValueTuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) =>
			new ValueTuple<T1, T2, T3>(item1, item2, item3);

		/// <summary>
		/// Creates a new 4-tuple.
		/// </summary>
		/// <param name="item1">The value of the component 1 of the tuple.</param>
		/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
		/// <param name="item2">The value of the component 2 of the tuple.</param>
		/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
		/// <param name="item3">The value of the component 3 of the tuple.</param>
		/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
		/// <param name="item4">The value of the component 4 of the tuple.</param>
		/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
		/// <returns>A 4-tuple whose value is (item1, item2).</returns>
		public static ValueTuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) =>
			new ValueTuple<T1, T2, T3, T4>(item1, item2, item3, item4);

		/// <summary>
		/// Creates a new 5-tuple.
		/// </summary>
		/// <param name="item1">The value of the component 1 of the tuple.</param>
		/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
		/// <param name="item2">The value of the component 2 of the tuple.</param>
		/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
		/// <param name="item3">The value of the component 3 of the tuple.</param>
		/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
		/// <param name="item4">The value of the component 4 of the tuple.</param>
		/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
		/// <param name="item5">The value of the component 5 of the tuple.</param>
		/// <typeparam name="T5">The type of the component 5 of the tuple.</typeparam>
		/// <returns>A 5-tuple whose value is (item1, item2).</returns>
		public static ValueTuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) =>
			new ValueTuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);

		/// <summary>
		/// Creates a new 6-tuple.
		/// </summary>
		/// <param name="item1">The value of the component 1 of the tuple.</param>
		/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
		/// <param name="item2">The value of the component 2 of the tuple.</param>
		/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
		/// <param name="item3">The value of the component 3 of the tuple.</param>
		/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
		/// <param name="item4">The value of the component 4 of the tuple.</param>
		/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
		/// <param name="item5">The value of the component 5 of the tuple.</param>
		/// <typeparam name="T5">The type of the component 5 of the tuple.</typeparam>
		/// <param name="item6">The value of the component 6 of the tuple.</param>
		/// <typeparam name="T6">The type of the component 6 of the tuple.</typeparam>
		/// <returns>A 6-tuple whose value is (item1, item2).</returns>
		public static ValueTuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) =>
			new ValueTuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);

		/// <summary>
		/// Creates a new 7-tuple.
		/// </summary>
		/// <param name="item1">The value of the component 1 of the tuple.</param>
		/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
		/// <param name="item2">The value of the component 2 of the tuple.</param>
		/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
		/// <param name="item3">The value of the component 3 of the tuple.</param>
		/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
		/// <param name="item4">The value of the component 4 of the tuple.</param>
		/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
		/// <param name="item5">The value of the component 5 of the tuple.</param>
		/// <typeparam name="T5">The type of the component 5 of the tuple.</typeparam>
		/// <param name="item6">The value of the component 6 of the tuple.</param>
		/// <typeparam name="T6">The type of the component 6 of the tuple.</typeparam>
		/// <param name="item7">The value of the component 7 of the tuple.</param>
		/// <typeparam name="T7">The type of the component 7 of the tuple.</typeparam>
		/// <returns>A 7-tuple whose value is (item1, item2).</returns>
		public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) =>
			new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);

		/// <summary>
		/// Creates a new 8-tuple.
		/// </summary>
		/// <param name="item1">The value of the component 1 of the tuple.</param>
		/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
		/// <param name="item2">The value of the component 2 of the tuple.</param>
		/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
		/// <param name="item3">The value of the component 3 of the tuple.</param>
		/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
		/// <param name="item4">The value of the component 4 of the tuple.</param>
		/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
		/// <param name="item5">The value of the component 5 of the tuple.</param>
		/// <typeparam name="T5">The type of the component 5 of the tuple.</typeparam>
		/// <param name="item6">The value of the component 6 of the tuple.</param>
		/// <typeparam name="T6">The type of the component 6 of the tuple.</typeparam>
		/// <param name="item7">The value of the component 7 of the tuple.</param>
		/// <typeparam name="T7">The type of the component 7 of the tuple.</typeparam>
		/// <param name="item8">The value of the component 8 of the tuple.</param>
		/// <typeparam name="T8">The type of the component 8 of the tuple.</typeparam>
		/// <returns>A 8-tuple whose value is (item1, item2).</returns>
		public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) =>
			new ValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);

	}

	/// <summary>
	/// Represents a 2-tuple.
	/// </summary>
	/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
	/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
	[Serializable]
	[PublicAPI]
	public struct ValueTuple<T1, T2> : IValueTuple, IStructuralEquatable, IStructuralComparable, IComparable
	{
		/// <summary>
		/// The value of the component 1 of the tuple.
		/// </summary>
		public T1 Item1 { get; }

		/// <summary>
		/// The value of the component 2 of the tuple.
		/// </summary>
		public T2 Item2 { get; }

		/// <summary>
		/// Initialize instance.
		/// </summary>
		public ValueTuple(T1 item1, T2 item2)
		{
			Item1 = item1;
			Item2 = item2;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns>
		/// true if the specified object  is equal to the current object; otherwise, false.
		/// </returns>
		/// <param name="obj">The object to compare with the current object. </param>
		public override bool Equals(object obj) =>
			((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (!(other is ValueTuple<T1, T2>))
				return false;

			var objTuple = (ValueTuple<T1, T2>)other;
			return comparer.Equals(Item1, objTuple.Item1) && comparer.Equals(Item2, objTuple.Item2);
		}

		int IComparable.CompareTo(object obj) => ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null) return 1;

			Code.AssertArgument(other is ValueTuple<T1, T2>, nameof (other), "Incorrect tuple");

			var objTuple = (ValueTuple<T1, T2>)other;
			int c = 0;
			c = comparer.Compare(Item1, objTuple.Item1);
			if (c != 0) return c;
			return comparer.Compare(Item2, objTuple.Item2);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>
		/// A 32-bit signed integer that is the hash code for this instance.
		/// </returns>
		public override int GetHashCode() => ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) =>
			HashCode.Combine(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2));

		/// <summary>
		/// Returns the fully qualified type name of this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> containing a fully qualified type name.
		/// </returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("(");
			sb.Append(Item1);
			sb.Append(", ");
			sb.Append(Item2);
			return sb.ToString();
		}

		#region Implementation of IValueTuple
		int IValueTuple.Rank => 2;

		object IValueTuple.this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return Item1;
					case 1: return Item2;
					default: throw new ArgumentOutOfRangeException(nameof(index));
				}
			}
		}
		#endregion
	}

	/// <summary>
	/// Represents a 3-tuple.
	/// </summary>
	/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
	/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
	/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
	[Serializable]
	[PublicAPI]
	public struct ValueTuple<T1, T2, T3> : IValueTuple, IStructuralEquatable, IStructuralComparable, IComparable
	{
		/// <summary>
		/// The value of the component 1 of the tuple.
		/// </summary>
		public T1 Item1 { get; }

		/// <summary>
		/// The value of the component 2 of the tuple.
		/// </summary>
		public T2 Item2 { get; }

		/// <summary>
		/// The value of the component 3 of the tuple.
		/// </summary>
		public T3 Item3 { get; }

		/// <summary>
		/// Initialize instance.
		/// </summary>
		public ValueTuple(T1 item1, T2 item2, T3 item3)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns>
		/// true if the specified object  is equal to the current object; otherwise, false.
		/// </returns>
		/// <param name="obj">The object to compare with the current object. </param>
		public override bool Equals(object obj) =>
			((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (!(other is ValueTuple<T1, T2, T3>))
				return false;

			var objTuple = (ValueTuple<T1, T2, T3>)other;
			return comparer.Equals(Item1, objTuple.Item1) && comparer.Equals(Item2, objTuple.Item2) && comparer.Equals(Item3, objTuple.Item3);
		}

		int IComparable.CompareTo(object obj) => ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null) return 1;

			Code.AssertArgument(other is ValueTuple<T1, T2, T3>, nameof (other), "Incorrect tuple");

			var objTuple = (ValueTuple<T1, T2, T3>)other;
			int c = 0;
			c = comparer.Compare(Item1, objTuple.Item1);
			if (c != 0) return c;
			c = comparer.Compare(Item2, objTuple.Item2);
			if (c != 0) return c;
			return comparer.Compare(Item3, objTuple.Item3);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>
		/// A 32-bit signed integer that is the hash code for this instance.
		/// </returns>
		public override int GetHashCode() => ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) =>
			HashCode.Combine(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3));

		/// <summary>
		/// Returns the fully qualified type name of this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> containing a fully qualified type name.
		/// </returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("(");
			sb.Append(Item1);
			sb.Append(", ");
			sb.Append(Item2);
			sb.Append(", ");
			sb.Append(Item3);
			return sb.ToString();
		}

		#region Implementation of IValueTuple
		int IValueTuple.Rank => 3;

		object IValueTuple.this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					default: throw new ArgumentOutOfRangeException(nameof(index));
				}
			}
		}
		#endregion
	}

	/// <summary>
	/// Represents a 4-tuple.
	/// </summary>
	/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
	/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
	/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
	/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
	[Serializable]
	[PublicAPI]
	public struct ValueTuple<T1, T2, T3, T4> : IValueTuple, IStructuralEquatable, IStructuralComparable, IComparable
	{
		/// <summary>
		/// The value of the component 1 of the tuple.
		/// </summary>
		public T1 Item1 { get; }

		/// <summary>
		/// The value of the component 2 of the tuple.
		/// </summary>
		public T2 Item2 { get; }

		/// <summary>
		/// The value of the component 3 of the tuple.
		/// </summary>
		public T3 Item3 { get; }

		/// <summary>
		/// The value of the component 4 of the tuple.
		/// </summary>
		public T4 Item4 { get; }

		/// <summary>
		/// Initialize instance.
		/// </summary>
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns>
		/// true if the specified object  is equal to the current object; otherwise, false.
		/// </returns>
		/// <param name="obj">The object to compare with the current object. </param>
		public override bool Equals(object obj) =>
			((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (!(other is ValueTuple<T1, T2, T3, T4>))
				return false;

			var objTuple = (ValueTuple<T1, T2, T3, T4>)other;
			return comparer.Equals(Item1, objTuple.Item1) && comparer.Equals(Item2, objTuple.Item2) && comparer.Equals(Item3, objTuple.Item3) && comparer.Equals(Item4, objTuple.Item4);
		}

		int IComparable.CompareTo(object obj) => ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null) return 1;

			Code.AssertArgument(other is ValueTuple<T1, T2, T3, T4>, nameof (other), "Incorrect tuple");

			var objTuple = (ValueTuple<T1, T2, T3, T4>)other;
			int c = 0;
			c = comparer.Compare(Item1, objTuple.Item1);
			if (c != 0) return c;
			c = comparer.Compare(Item2, objTuple.Item2);
			if (c != 0) return c;
			c = comparer.Compare(Item3, objTuple.Item3);
			if (c != 0) return c;
			return comparer.Compare(Item4, objTuple.Item4);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>
		/// A 32-bit signed integer that is the hash code for this instance.
		/// </returns>
		public override int GetHashCode() => ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) =>
			HashCode.Combine(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4));

		/// <summary>
		/// Returns the fully qualified type name of this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> containing a fully qualified type name.
		/// </returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("(");
			sb.Append(Item1);
			sb.Append(", ");
			sb.Append(Item2);
			sb.Append(", ");
			sb.Append(Item3);
			sb.Append(", ");
			sb.Append(Item4);
			return sb.ToString();
		}

		#region Implementation of IValueTuple
		int IValueTuple.Rank => 4;

		object IValueTuple.this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					default: throw new ArgumentOutOfRangeException(nameof(index));
				}
			}
		}
		#endregion
	}

	/// <summary>
	/// Represents a 5-tuple.
	/// </summary>
	/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
	/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
	/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
	/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
	/// <typeparam name="T5">The type of the component 5 of the tuple.</typeparam>
	[Serializable]
	[PublicAPI]
	public struct ValueTuple<T1, T2, T3, T4, T5> : IValueTuple, IStructuralEquatable, IStructuralComparable, IComparable
	{
		/// <summary>
		/// The value of the component 1 of the tuple.
		/// </summary>
		public T1 Item1 { get; }

		/// <summary>
		/// The value of the component 2 of the tuple.
		/// </summary>
		public T2 Item2 { get; }

		/// <summary>
		/// The value of the component 3 of the tuple.
		/// </summary>
		public T3 Item3 { get; }

		/// <summary>
		/// The value of the component 4 of the tuple.
		/// </summary>
		public T4 Item4 { get; }

		/// <summary>
		/// The value of the component 5 of the tuple.
		/// </summary>
		public T5 Item5 { get; }

		/// <summary>
		/// Initialize instance.
		/// </summary>
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns>
		/// true if the specified object  is equal to the current object; otherwise, false.
		/// </returns>
		/// <param name="obj">The object to compare with the current object. </param>
		public override bool Equals(object obj) =>
			((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (!(other is ValueTuple<T1, T2, T3, T4, T5>))
				return false;

			var objTuple = (ValueTuple<T1, T2, T3, T4, T5>)other;
			return comparer.Equals(Item1, objTuple.Item1) && comparer.Equals(Item2, objTuple.Item2) && comparer.Equals(Item3, objTuple.Item3) && comparer.Equals(Item4, objTuple.Item4) && comparer.Equals(Item5, objTuple.Item5);
		}

		int IComparable.CompareTo(object obj) => ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null) return 1;

			Code.AssertArgument(other is ValueTuple<T1, T2, T3, T4, T5>, nameof (other), "Incorrect tuple");

			var objTuple = (ValueTuple<T1, T2, T3, T4, T5>)other;
			int c = 0;
			c = comparer.Compare(Item1, objTuple.Item1);
			if (c != 0) return c;
			c = comparer.Compare(Item2, objTuple.Item2);
			if (c != 0) return c;
			c = comparer.Compare(Item3, objTuple.Item3);
			if (c != 0) return c;
			c = comparer.Compare(Item4, objTuple.Item4);
			if (c != 0) return c;
			return comparer.Compare(Item5, objTuple.Item5);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>
		/// A 32-bit signed integer that is the hash code for this instance.
		/// </returns>
		public override int GetHashCode() => ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) =>
			HashCode.Combine(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5));

		/// <summary>
		/// Returns the fully qualified type name of this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> containing a fully qualified type name.
		/// </returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("(");
			sb.Append(Item1);
			sb.Append(", ");
			sb.Append(Item2);
			sb.Append(", ");
			sb.Append(Item3);
			sb.Append(", ");
			sb.Append(Item4);
			sb.Append(", ");
			sb.Append(Item5);
			return sb.ToString();
		}

		#region Implementation of IValueTuple
		int IValueTuple.Rank => 5;

		object IValueTuple.this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					default: throw new ArgumentOutOfRangeException(nameof(index));
				}
			}
		}
		#endregion
	}

	/// <summary>
	/// Represents a 6-tuple.
	/// </summary>
	/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
	/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
	/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
	/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
	/// <typeparam name="T5">The type of the component 5 of the tuple.</typeparam>
	/// <typeparam name="T6">The type of the component 6 of the tuple.</typeparam>
	[Serializable]
	[PublicAPI]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6> : IValueTuple, IStructuralEquatable, IStructuralComparable, IComparable
	{
		/// <summary>
		/// The value of the component 1 of the tuple.
		/// </summary>
		public T1 Item1 { get; }

		/// <summary>
		/// The value of the component 2 of the tuple.
		/// </summary>
		public T2 Item2 { get; }

		/// <summary>
		/// The value of the component 3 of the tuple.
		/// </summary>
		public T3 Item3 { get; }

		/// <summary>
		/// The value of the component 4 of the tuple.
		/// </summary>
		public T4 Item4 { get; }

		/// <summary>
		/// The value of the component 5 of the tuple.
		/// </summary>
		public T5 Item5 { get; }

		/// <summary>
		/// The value of the component 6 of the tuple.
		/// </summary>
		public T6 Item6 { get; }

		/// <summary>
		/// Initialize instance.
		/// </summary>
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns>
		/// true if the specified object  is equal to the current object; otherwise, false.
		/// </returns>
		/// <param name="obj">The object to compare with the current object. </param>
		public override bool Equals(object obj) =>
			((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (!(other is ValueTuple<T1, T2, T3, T4, T5, T6>))
				return false;

			var objTuple = (ValueTuple<T1, T2, T3, T4, T5, T6>)other;
			return comparer.Equals(Item1, objTuple.Item1) && comparer.Equals(Item2, objTuple.Item2) && comparer.Equals(Item3, objTuple.Item3) && comparer.Equals(Item4, objTuple.Item4) && comparer.Equals(Item5, objTuple.Item5) && comparer.Equals(Item6, objTuple.Item6);
		}

		int IComparable.CompareTo(object obj) => ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null) return 1;

			Code.AssertArgument(other is ValueTuple<T1, T2, T3, T4, T5, T6>, nameof (other), "Incorrect tuple");

			var objTuple = (ValueTuple<T1, T2, T3, T4, T5, T6>)other;
			int c = 0;
			c = comparer.Compare(Item1, objTuple.Item1);
			if (c != 0) return c;
			c = comparer.Compare(Item2, objTuple.Item2);
			if (c != 0) return c;
			c = comparer.Compare(Item3, objTuple.Item3);
			if (c != 0) return c;
			c = comparer.Compare(Item4, objTuple.Item4);
			if (c != 0) return c;
			c = comparer.Compare(Item5, objTuple.Item5);
			if (c != 0) return c;
			return comparer.Compare(Item6, objTuple.Item6);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>
		/// A 32-bit signed integer that is the hash code for this instance.
		/// </returns>
		public override int GetHashCode() => ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) =>
			HashCode.Combine(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6));

		/// <summary>
		/// Returns the fully qualified type name of this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> containing a fully qualified type name.
		/// </returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("(");
			sb.Append(Item1);
			sb.Append(", ");
			sb.Append(Item2);
			sb.Append(", ");
			sb.Append(Item3);
			sb.Append(", ");
			sb.Append(Item4);
			sb.Append(", ");
			sb.Append(Item5);
			sb.Append(", ");
			sb.Append(Item6);
			return sb.ToString();
		}

		#region Implementation of IValueTuple
		int IValueTuple.Rank => 6;

		object IValueTuple.this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					default: throw new ArgumentOutOfRangeException(nameof(index));
				}
			}
		}
		#endregion
	}

	/// <summary>
	/// Represents a 7-tuple.
	/// </summary>
	/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
	/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
	/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
	/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
	/// <typeparam name="T5">The type of the component 5 of the tuple.</typeparam>
	/// <typeparam name="T6">The type of the component 6 of the tuple.</typeparam>
	/// <typeparam name="T7">The type of the component 7 of the tuple.</typeparam>
	[Serializable]
	[PublicAPI]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7> : IValueTuple, IStructuralEquatable, IStructuralComparable, IComparable
	{
		/// <summary>
		/// The value of the component 1 of the tuple.
		/// </summary>
		public T1 Item1 { get; }

		/// <summary>
		/// The value of the component 2 of the tuple.
		/// </summary>
		public T2 Item2 { get; }

		/// <summary>
		/// The value of the component 3 of the tuple.
		/// </summary>
		public T3 Item3 { get; }

		/// <summary>
		/// The value of the component 4 of the tuple.
		/// </summary>
		public T4 Item4 { get; }

		/// <summary>
		/// The value of the component 5 of the tuple.
		/// </summary>
		public T5 Item5 { get; }

		/// <summary>
		/// The value of the component 6 of the tuple.
		/// </summary>
		public T6 Item6 { get; }

		/// <summary>
		/// The value of the component 7 of the tuple.
		/// </summary>
		public T7 Item7 { get; }

		/// <summary>
		/// Initialize instance.
		/// </summary>
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
			Item7 = item7;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns>
		/// true if the specified object  is equal to the current object; otherwise, false.
		/// </returns>
		/// <param name="obj">The object to compare with the current object. </param>
		public override bool Equals(object obj) =>
			((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (!(other is ValueTuple<T1, T2, T3, T4, T5, T6, T7>))
				return false;

			var objTuple = (ValueTuple<T1, T2, T3, T4, T5, T6, T7>)other;
			return comparer.Equals(Item1, objTuple.Item1) && comparer.Equals(Item2, objTuple.Item2) && comparer.Equals(Item3, objTuple.Item3) && comparer.Equals(Item4, objTuple.Item4) && comparer.Equals(Item5, objTuple.Item5) && comparer.Equals(Item6, objTuple.Item6) && comparer.Equals(Item7, objTuple.Item7);
		}

		int IComparable.CompareTo(object obj) => ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null) return 1;

			Code.AssertArgument(other is ValueTuple<T1, T2, T3, T4, T5, T6, T7>, nameof (other), "Incorrect tuple");

			var objTuple = (ValueTuple<T1, T2, T3, T4, T5, T6, T7>)other;
			int c = 0;
			c = comparer.Compare(Item1, objTuple.Item1);
			if (c != 0) return c;
			c = comparer.Compare(Item2, objTuple.Item2);
			if (c != 0) return c;
			c = comparer.Compare(Item3, objTuple.Item3);
			if (c != 0) return c;
			c = comparer.Compare(Item4, objTuple.Item4);
			if (c != 0) return c;
			c = comparer.Compare(Item5, objTuple.Item5);
			if (c != 0) return c;
			c = comparer.Compare(Item6, objTuple.Item6);
			if (c != 0) return c;
			return comparer.Compare(Item7, objTuple.Item7);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>
		/// A 32-bit signed integer that is the hash code for this instance.
		/// </returns>
		public override int GetHashCode() => ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) =>
			HashCode.Combine(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7));

		/// <summary>
		/// Returns the fully qualified type name of this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> containing a fully qualified type name.
		/// </returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("(");
			sb.Append(Item1);
			sb.Append(", ");
			sb.Append(Item2);
			sb.Append(", ");
			sb.Append(Item3);
			sb.Append(", ");
			sb.Append(Item4);
			sb.Append(", ");
			sb.Append(Item5);
			sb.Append(", ");
			sb.Append(Item6);
			sb.Append(", ");
			sb.Append(Item7);
			return sb.ToString();
		}

		#region Implementation of IValueTuple
		int IValueTuple.Rank => 7;

		object IValueTuple.this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					case 6: return Item7;
					default: throw new ArgumentOutOfRangeException(nameof(index));
				}
			}
		}
		#endregion
	}

	/// <summary>
	/// Represents a 8-tuple.
	/// </summary>
	/// <typeparam name="T1">The type of the component 1 of the tuple.</typeparam>
	/// <typeparam name="T2">The type of the component 2 of the tuple.</typeparam>
	/// <typeparam name="T3">The type of the component 3 of the tuple.</typeparam>
	/// <typeparam name="T4">The type of the component 4 of the tuple.</typeparam>
	/// <typeparam name="T5">The type of the component 5 of the tuple.</typeparam>
	/// <typeparam name="T6">The type of the component 6 of the tuple.</typeparam>
	/// <typeparam name="T7">The type of the component 7 of the tuple.</typeparam>
	/// <typeparam name="T8">The type of the component 8 of the tuple.</typeparam>
	[Serializable]
	[PublicAPI]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, T8> : IValueTuple, IStructuralEquatable, IStructuralComparable, IComparable
	{
		/// <summary>
		/// The value of the component 1 of the tuple.
		/// </summary>
		public T1 Item1 { get; }

		/// <summary>
		/// The value of the component 2 of the tuple.
		/// </summary>
		public T2 Item2 { get; }

		/// <summary>
		/// The value of the component 3 of the tuple.
		/// </summary>
		public T3 Item3 { get; }

		/// <summary>
		/// The value of the component 4 of the tuple.
		/// </summary>
		public T4 Item4 { get; }

		/// <summary>
		/// The value of the component 5 of the tuple.
		/// </summary>
		public T5 Item5 { get; }

		/// <summary>
		/// The value of the component 6 of the tuple.
		/// </summary>
		public T6 Item6 { get; }

		/// <summary>
		/// The value of the component 7 of the tuple.
		/// </summary>
		public T7 Item7 { get; }

		/// <summary>
		/// The value of the component 8 of the tuple.
		/// </summary>
		public T8 Item8 { get; }

		/// <summary>
		/// Initialize instance.
		/// </summary>
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			Item1 = item1;
			Item2 = item2;
			Item3 = item3;
			Item4 = item4;
			Item5 = item5;
			Item6 = item6;
			Item7 = item7;
			Item8 = item8;
		}

		/// <summary>
		/// Determines whether the specified object is equal to the current object.
		/// </summary>
		/// <returns>
		/// true if the specified object  is equal to the current object; otherwise, false.
		/// </returns>
		/// <param name="obj">The object to compare with the current object. </param>
		public override bool Equals(object obj) =>
			((IStructuralEquatable)this).Equals(obj, EqualityComparer<object>.Default);

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (!(other is ValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>))
				return false;

			var objTuple = (ValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>)other;
			return comparer.Equals(Item1, objTuple.Item1) && comparer.Equals(Item2, objTuple.Item2) && comparer.Equals(Item3, objTuple.Item3) && comparer.Equals(Item4, objTuple.Item4) && comparer.Equals(Item5, objTuple.Item5) && comparer.Equals(Item6, objTuple.Item6) && comparer.Equals(Item7, objTuple.Item7) && comparer.Equals(Item8, objTuple.Item8);
		}

		int IComparable.CompareTo(object obj) => ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null) return 1;

			Code.AssertArgument(other is ValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>, nameof (other), "Incorrect tuple");

			var objTuple = (ValueTuple<T1, T2, T3, T4, T5, T6, T7, T8>)other;
			int c = 0;
			c = comparer.Compare(Item1, objTuple.Item1);
			if (c != 0) return c;
			c = comparer.Compare(Item2, objTuple.Item2);
			if (c != 0) return c;
			c = comparer.Compare(Item3, objTuple.Item3);
			if (c != 0) return c;
			c = comparer.Compare(Item4, objTuple.Item4);
			if (c != 0) return c;
			c = comparer.Compare(Item5, objTuple.Item5);
			if (c != 0) return c;
			c = comparer.Compare(Item6, objTuple.Item6);
			if (c != 0) return c;
			c = comparer.Compare(Item7, objTuple.Item7);
			if (c != 0) return c;
			return comparer.Compare(Item8, objTuple.Item8);
		}

		/// <summary>
		/// Returns the hash code for this instance.
		/// </summary>
		/// <returns>
		/// A 32-bit signed integer that is the hash code for this instance.
		/// </returns>
		public override int GetHashCode() => ((IStructuralEquatable)this).GetHashCode(EqualityComparer<object>.Default);

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) =>
			HashCode.Combine(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6), comparer.GetHashCode(Item7), comparer.GetHashCode(Item8));

		/// <summary>
		/// Returns the fully qualified type name of this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"/> containing a fully qualified type name.
		/// </returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("(");
			sb.Append(Item1);
			sb.Append(", ");
			sb.Append(Item2);
			sb.Append(", ");
			sb.Append(Item3);
			sb.Append(", ");
			sb.Append(Item4);
			sb.Append(", ");
			sb.Append(Item5);
			sb.Append(", ");
			sb.Append(Item6);
			sb.Append(", ");
			sb.Append(Item7);
			sb.Append(", ");
			sb.Append(Item8);
			return sb.ToString();
		}

		#region Implementation of IValueTuple
		int IValueTuple.Rank => 8;

		object IValueTuple.this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return Item1;
					case 1: return Item2;
					case 2: return Item3;
					case 3: return Item4;
					case 4: return Item5;
					case 5: return Item6;
					case 6: return Item7;
					case 7: return Item8;
					default: throw new ArgumentOutOfRangeException(nameof(index));
				}
			}
		}
		#endregion
	}

}