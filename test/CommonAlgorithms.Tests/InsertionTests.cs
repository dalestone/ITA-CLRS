﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CommonAlgorithms.Tests
{
    public class InsertionTests
    {
        private readonly Insertion _insertion;

        public InsertionTests()
        {
            _insertion = new Insertion();
        }

        [Fact]
        public void ReturnSortedArrayAscending()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };
            var actual = _insertion.InsertionSort(A);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSortedArrayAscendingUsingLINQ()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };
            var actual = A.OrderBy(n => n).ToArray();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSortedArrayAscendingUsingArraySort()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 1, 2, 3, 4, 5, 6 };

            Array.Sort<int>(A,
                            new Comparison<int>(
                                (i1, i2) => i1.CompareTo(i2)
                            ));

            Assert.Equal(expected, A);
        }

        [Fact]
        public void ReturnSortedArrayDescending()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 6, 5, 4, 3, 2, 1 };
            var actual = _insertion.InsertionSortDescending(A);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSortedArrayDescendingUsingLINQ()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 6, 5, 4, 3, 2, 1 };
            var actual = A.OrderByDescending(n => n).ToArray();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnSortedArrayDescendingUsingArraySort()
        {
            var A = new int[] { 5, 2, 4, 6, 1, 3 };
            var expected = new int[] { 6, 5, 4, 3, 2, 1 };
            var actual = A.OrderByDescending(n => n).ToArray();

            Array.Sort<int>(A,
                            new Comparison<int>(
                                (i1, i2) => i2.CompareTo(i1)
                            ));

            Assert.Equal(expected, A);
        }

        [Fact]
        public void CLRS_2_1_1()
        {
            var A = new int[] { 31, 41, 59, 26, 41, 58 };
            var expected = new int[] { 26, 31, 41, 41, 58, 59 };
            var actual = _insertion.InsertionSort(A);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CLRS_2_1_2()
        {
            var A = new int[] { 31, 41, 59, 26, 41, 58 };
            var expected = new int[] { 59, 58, 41, 41, 31, 26 };
            var actual = _insertion.InsertionSortDescending(A);

            Assert.Equal(expected, actual);
        }
    }
}
