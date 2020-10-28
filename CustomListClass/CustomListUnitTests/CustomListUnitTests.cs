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

        //check if added lists stringified is accurate
        [TestMethod]
        public void PlusOperator_AddTwoCustomListsGetString_StringIsExpected()
        {
            //arrange
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            CustomList<string> testList3;
            string expected = "0, 1, 2, 3, 10, 11, 12"; //0, 1, 2, 3, 10, 11, 12 == 22 chars
            string actual;

            //act
            for (int i = 0; i < 3; i++)
            {
                testList1.Add($"{i}");
                testList2.Add($"{i + 10}");
            }
            testList1.Add("3");
            testList3 = testList1 + testList2;
            actual = testList3.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }

        /*
         * Unit tests for - operator overload method
         */


        //Add 2 lists, subtract one of them, the other should remain, compare string representations of them
        [TestMethod]
        public void MinusOperator_AddTwoListsThenSubtractOne_FirstSingleListIsExpected()
        {
            //arrange
            CustomList<int> expected = new CustomList<int>();
            for (int i = 1; i < 4; i++)
            {
                expected.Add(i); // 1, 2, 3
            }

            CustomList<int> list2 = new CustomList<int>();
            for (int i = 1; i < 4; i++)
            {
                list2.Add(i + 10); // 11, 12, 13
            }

            CustomList<int> list3 = expected + list2; // 1, 2, 3, 11, 12, 13
            

            //act
            CustomList<int> actual = list3 - list2;//1, 2, 3

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        //Add 2 lists, subtract part of one, the remaining parts should remain in the new list (check via string comparison)
        //Add (1, 2, 3) + (4, 5, 6)
        //Subtract (1, 2, 3, 4, 5 , 6) - (2, 5)
        //Expected (1, 3, 4, 6)
        [TestMethod]
        public void MinusOperator_AddTwoListsThenSubtractPartial_PartialListMeetsExpected()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            for (int i = 1; i < 4; i++)
            {
                list1.Add(i); // 1, 2, 3
            }

            CustomList<int> list2 = new CustomList<int>();
            for (int i = 4; i < 7; i++)
            {
                list2.Add(i); // 4, 5, 6
            }

            CustomList<int> list3 = list1 + list2; // 1, 2, 3, 4, 5, 6
            CustomList<int> list4 = new CustomList<int>();
            list4.Add(2);
            list4.Add(5);
            string expected = "1, 3, 4, 6";
            string actual;

            //act
            CustomList<int> actuallist = list3 - list4;//should be 1, 3, 4, 6
            actual = actuallist.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Add 2 lists, subtract part of one, the count of the the new list should be known/expected value
        //Add (1, 2, 3, 4, 5) + (6, 7, 8)
        //Subtract (1, 2, 3, 4, 5 , 6, 7, 8) - (2, 5)
        //Expected (1, 3, 4, 6, 7, 8): Count = 6
        [TestMethod]
        public void MinusOperator_AddTwoListsThenSubtractPartial_CountIsList1CountMinusListTwoCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            for (int i = 1; i < 6; i++)
            {
                list1.Add(i); // 1, 2, 3, 4, 5
            }

            CustomList<int> list2 = new CustomList<int>();
            for (int i = 6; i < 9; i++)
            {
                list2.Add(i); // 6, 7, 8
            }

            CustomList<int> list3 = list1 + list2; // 1, 2, 3, 4, 5, 6, 7, 8: count = 8
            CustomList<int> list4 = new CustomList<int>();
            list4.Add(2);// 2: count = 1
            list4.Add(5);// 2, 5: count = 2
            int expected = 6;
            int actual;

            //act
            CustomList<int> actuallist = list3 - list4;//should be 1, 3, 4, 6
            actual = actuallist.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }


        //Add 2 lists, subtract an empty list, only sum should remain (compare string values)
        [TestMethod]
        public void MinusOperator_AddTwoListsThenSubtractEmpty_ExpectSumLists()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            for (int i = 1; i < 4; i++)
            {
                list1.Add(i); // 1, 2, 3
            }

            CustomList<int> list2 = new CustomList<int>();
            for (int i = 1; i < 4; i++)
            {
                list2.Add(i + 10); // 11, 12, 13
            }
            CustomList<int> emptyList = new CustomList<int>();

            CustomList<int> expectedList = list1 + list2; // 1, 2, 3, 11, 12, 13


            //act
            CustomList<int> actualList = expectedList - emptyList;//1, 2, 3

            //assert
            Assert.AreEqual(expectedList.ToString(), actualList.ToString());
        }
    }
}
