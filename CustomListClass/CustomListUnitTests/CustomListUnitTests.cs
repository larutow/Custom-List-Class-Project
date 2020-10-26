using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace CustomListUnitTests
{
    [TestClass]
    public class CustomListUnitTests
    {
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

        //what if you add an item that has things in it already?(Position of item, index)
        [TestMethod]
        public void Add_AddItemToNonEmptyList_ItemGoesToIndex2()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 10;
            int actual;
            //act
            testList.Add(0);
            testList.Add(0);
            testList.Add(item);
            actual = testList[2]; //error expected until indexer added to custom class

            //assert
            Assert.AreEqual(expected, actual);
        }

        //what if you add an item that has things in it already?(value of count)
        [TestMethod]
        public void Add_AddItemToNonEmptyList_CountIncrementsToThree()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 3;
            int actual;
            //act
            testList.Add(0);
            testList.Add(0);
            testList.Add(item);
            actual = testList.Count; //error expected until indexer added to custom class

            //assert
            Assert.AreEqual(expected, actual);
        }

        //how does the capacity change as you add things? (starts at 4 & doubles)


    }
}
