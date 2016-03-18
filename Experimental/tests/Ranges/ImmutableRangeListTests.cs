﻿using System;

using NUnit.Framework;

namespace CodeJam.Ranges
{
    [TestFixture]
    public class ImmutableRangeListTests
    {
        [Test]
        public void Contains()
        {
			// TODO:
        }


        [Test]
        public void Invert()
        {
            var list = Range.Create(20, 30).ToRangeList().Add(Range.Create(11, 12, false, true));
            CheckList(list, "[(11)..12, 20..30]");

            var invertedList = list.Invert();
            CheckList(invertedList, "[..11, (12)..(20), (30)..]");

            var invertedAgain = invertedList.Invert();
            CheckList(invertedAgain, "[(11)..12, 20..30]");

            Assert.AreEqual(list, invertedAgain);
        }


        private void CheckList<TValue>(ImmutableRangeList<TValue> list, string representation)
            where TValue : IComparable<TValue>
        {
            Assert.AreEqual(list.DisplayValue(), representation);
        }

    }
}