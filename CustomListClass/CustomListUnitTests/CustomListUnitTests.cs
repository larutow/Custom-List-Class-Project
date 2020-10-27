using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

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

        //checkt to see if capacity remains after removing items
        [TestMethod]

        public void Remove_RemoveFiveElements_CapacityIsEight()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            //act
            for(int i = 0; i < 5; i++)
            {
                testList.Add(2);
            }
            for(int i = 0; i < 5; i++)
            {
                testList.Remove(2);
            }
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }



    }
}
