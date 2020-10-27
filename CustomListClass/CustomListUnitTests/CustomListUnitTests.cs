using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;
using System.Collections.Generic;

namespace CustomListUnitTests
{
    [TestClass]
    public class CustomListUnitTests
    {
        //Test to add item(number) to empty list - ensure value of added item = value of input item to add method
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 10;
            int actual;
            //act
            testList.Add(item);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Test to add add item (int number) to empty list - ensure that count is accurate
        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual;
            //act
            testList.Add(item);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Test to add an item that has something in it already (Verify position of item, index is accurate)
        [TestMethod]
        public void Add_AddItemToNonEmptyList_ItemGoesToIndex4()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 10;
            int actual;
            //act
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(item);
            actual = testList[4];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Test to add an item to a 'list' that already contains data (verify value of count is correct)
        [TestMethod]
        public void Add_AddItemToNonEmptyList_CountIncrementsToFive()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 5;
            int actual;
            //act
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(item);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddFifthElement_CapacitySizeDoubles()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            //act
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(2);
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        /*
         * Remove method testing
         */

        //check to see if count decreases after removing item
        [TestMethod]
        public void Remove_RemoveFirstElement_CountGoesToZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 0;
            int actual;

            //act
            testList.Add(2);
            testList.Remove(2);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //check to see if index of removed item now contains second item
        [TestMethod]
        public void Remove_RemoveFirstElement_IndexZeroEqualsIndexOneVal()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            //act
            testList.Add(2);
            testList.Add(3);
            testList.Remove(2);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //check to see if index of third index contains fourth (shifting) after removing first index
        [TestMethod]
        public void Remove_RemoveFirstElement_Index2EqualsIndexThreeVal()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 400;
            int actual;

            //act
            testList.Add(100);
            testList.Add(200);
            testList.Add(300);
            testList.Add(400);
            testList.Remove(100);
            actual = testList[2];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //check to see if return bool is true on successful removal
        [TestMethod]
        public void Remove_RemoveContainedElement_BoolIsTrue()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = true;
            bool actual;

            //act
            testList.Add(2);
            actual = testList.Remove(2);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //check to see if return bool is false on unsuccessful removal
        [TestMethod]
        public void Remove_RemoveUnfoundElement_BoolIsFalse()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = false;
            bool actual;

            //act
            testList.Add(2);
            actual = testList.Remove(3);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //check to see if capacity remains after removing items
        [TestMethod]

        public void Remove_RemoveFiveElements_CapacityIsEight()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            //act
            for (int i = 0; i < 5; i++)
            {
                testList.Add(2);
            }
            for (int i = 0; i < 5; i++)
            {
                testList.Remove(2);
            }
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }

        /*
         * ToString Method
         */

        //Check if string.length = expected based upon a 5 element list of ints (1, 2, 3, 4, 5)
        //expect 13 chars (5 numbers, 4 spaces, 4 commas)
        [TestMethod]
        public void ToString_AddFiveElementsReturnString_LengthEqualsThirteen()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 13;
            string stringifiedList;
            int actual;

            //act
            for (int i = 1; i < 6; i++)
            {
                testList.Add(i);
            }
            stringifiedList = testList.ToString();
            //returns: "1, 2, 3, 4, 5"
            //expect 13 chars (5 numbers, 4 spaces, 4 commas)
            actual = stringifiedList.Length;

            //assert
            Assert.AreEqual(expected, actual);
        }

        //try to int.parse output strings first character and see if it matches expected [1]
        [TestMethod]
        public void ToString_AddFiveElementsReturnString_FirstElementOfStringEqualsOne()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            string stringifiedList;
            int actual;

            //act
            for (int i = 1; i < 6; i++)
            {
                testList.Add(i);
            }
            stringifiedList = testList.ToString();
            //returns: "1, 2, 3, 4, 5"
            //expect 1
            actual = int.Parse(stringifiedList[0].ToString());

            //assert
            Assert.AreEqual(expected, actual);
        }

        //try to int.parse output strings last character and see if it matches expected [5]
        [TestMethod]
        public void ToString_AddFiveElementsReturnString_13thElementOfStringEqualsFive()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            string stringifiedList;
            int actual;

            //act
            for (int i = 1; i < 6; i++)
            {
                testList.Add(i);
            }
            stringifiedList = testList.ToString();
            //returns: "1, 2, 3, 4, 5"
            //expect 1
            actual = int.Parse(stringifiedList[12].ToString());

            //assert
            Assert.AreEqual(expected, actual);
        }


        /*
         * Unit tests for + operator overload method
         */

        //check if count increases by 3 (to 6) as second list (count 3) is added to first (count 3)
        [TestMethod]
        public void PlusOperator_AddTwoCustomLists_CountEqualsSumOfCounts()
        {
            //arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3;
            int expected;
            int actual;

            //act
            for (int i = 0; i < 3; i++)
            {
                testList1.Add($"{i}");
                testList2.Add($"{i + 10}");
            }
            expected = testList1.Count + testList2.Count;
            testList3 = testList1 + testList2;
            actual = testList3.Count;

            //assert
            Assert.AreEqual(actual, expected);

        }

        //check if the first value of new list is equal to the first value of the first list
        [TestMethod]
        public void PlusOperator_AddTwoCustomLists_IndexZeroValyeEqualsFirstListIndexZeroValue()
        {
            //arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3;
            string expected;
            string actual;

            //act
            for (int i = 0; i < 3; i++)
            {
                testList1.Add($"{i}");
                testList2.Add($"{i + 10}");
            }
            expected = testList1[0];
            testList3 = testList1 + testList2;
            actual = testList3[0];

            //assert
            Assert.AreEqual(actual, expected);

        }

        //check if last value of the first list equals last value before second list values begin
        [TestMethod]
        public void PlusOperator_AddTwoCustomLists_LastValueOfFirstListEqualsLastValueBeforeSecondList()
        {
            //arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3;
            string expected;
            string actual;

            //act
            for (int i = 0; i < 3; i++)
            {
                testList1.Add($"{i}");
                testList2.Add($"{i + 10}");
            }
            expected = testList1[testList1.Count-1];
            testList3 = testList1 + testList2;
            actual = testList3[testList1.Count-1];

            //assert
            Assert.AreEqual(actual, expected);

        }

        //check if the fourth value of the new list is equal to the first value of the second list
        [TestMethod]
        public void PlusOperator_AddTwoCustomLists_IndexThreeEqualsSecondListIndexZero()
        {
            //arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3;
            string expected;
            string actual;

            //act
            for (int i = 0; i < 3; i++)
            {
                testList1.Add($"{i}");
                testList2.Add($"{i + 10}");
            }
            testList1.Add("3");
            expected = testList2[0];
            testList3 = testList1 + testList2;
            actual = testList3[testList1.Count];

            //assert
            Assert.AreEqual(actual, expected);

        }

        //check if last value of the new list is equal to the last value of the second list
        [TestMethod]
        public void PlusOperator_AddTwoCustomLists_LastIndexNewListEqualsLastIndexOfSecondAddend()
        {
            //arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3;
            string expected;
            string actual;

            //act
            for (int i = 0; i < 3; i++)
            {
                testList1.Add($"{i}");
                testList2.Add($"{i + 10}");
            }
            expected = testList2[testList2.Count-1];
            testList3 = testList1 + testList2;
            actual = testList3[testList3.Count-1];

            //assert
            Assert.AreEqual(actual, expected);

        }

        //check if added lists stringified length is accurate (add list of 4 + list of 3 == 22 char length string)
        [TestMethod]
        public void PlusOperator_AddTwoCustomListsGetStringLength_StringLengthI()
        {
            //arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3;
            int expected = 22; //0, 1, 2, 3, 10, 11, 12 == 22 chars
            int actual;

            //act
            for (int i = 0; i < 3; i++)
            {
                testList1.Add($"{i}");
                testList2.Add($"{i + 10}");
            }
            testList1.Add("3");
            testList3 = testList1 + testList2;
            actual = testList3.ToString().Length;

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
