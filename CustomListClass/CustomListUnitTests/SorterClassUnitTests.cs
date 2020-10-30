using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class SorterHelperUnitTests
    {

        /*
         * Unit tests for merge sort algo
         */

        [TestMethod]
        public void MergeSort_SortNumberListAscending_ExpectOutputLowestToHighest()
        {
            //arrange
            CustomList<int> unsortedList = new CustomList<int> { 2, 9, 4, 10, 6, 5, 3, 1, 7, 8 };
            CustomList<int> expected = new CustomList<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            SorterHelper sorterHelper = new SorterHelper();
            //act
            CustomList<int> actual = sorterHelper.MergeSort(unsortedList);

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        [TestMethod]
        public void MergeSort_SortNumberListAscendingWithRepetitiveValues_ExpectOutputLowestToHighest()
        {
            //arrange
            CustomList<int> unsortedList = new CustomList<int> { 2, 9, 6, 10, 6, 6, 3, 1, 7, 8 };
            CustomList<int> expected = new CustomList<int> { 1, 2, 3, 6, 6, 6, 7, 8, 9, 10 };
            SorterHelper sorterHelper = new SorterHelper();
            //act
            CustomList<int> actual = sorterHelper.MergeSort(unsortedList);


            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }


        [TestMethod]
        public void MergeSort_SortCharListAscending_ExpectOutputForwardAlphabetical()
        {
            //arrange
            CustomList<char> unsortedList = new CustomList<char> { 'b', 'z', 'a', 'v', 'h' };
            CustomList<char> expected = new CustomList<char> { 'a', 'b', 'h', 'v', 'z' };
            SorterHelper sorterHelper = new SorterHelper();
            //act
            CustomList<char> actual = sorterHelper.MergeSort(unsortedList);


            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

    }
}
