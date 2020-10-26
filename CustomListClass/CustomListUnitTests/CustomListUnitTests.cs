﻿using System;
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
            actual = testList[0]; //error expected until indexer added to custom class

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
            actual = testList.Count; //error expected until indexer added to custom class

            //assert
            Assert.AreEqual(expected, actual);
        }

        //Test to add an item that has something in it already (Verify position of item, index is accurate)
        [TestMethod]
        public void Add_AddItemToNonEmptyList_ItemGoesToIndex5()
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
            actual = testList[4]; //error expected until indexer added to custom class

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
            actual = testList.Count; //error expected until indexer added to custom class

            //assert
            Assert.AreEqual(expected, actual);
        }

       


    }
}
