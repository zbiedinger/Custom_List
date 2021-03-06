﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;


namespace CustomListTest
{
    [TestClass]
    public class MinusOverload
    {
        [TestMethod]
        public void MinusOperator_PositiveIntsRemoving1num_ListOf35()
        {
            //Arrange
            CustomList<int> intListOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> intListTwo = new CustomList<int>() { 2, 1, 6 };

            string expected = "35";
            CustomList<int> actualList;
            string actual = "";

            //Act
            actualList = intListOne - intListTwo;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_PositiveIntsRemoving2num_ListOf35()
        {
            //Arrange
            CustomList<int> intListTwo = new CustomList<int>() { 2,1,6,8};
            CustomList<int> intListOne = new CustomList<int>() { 1,3,5,8};

            string expected = "35";
            CustomList<int> actualList;
            string actual = "";

            //Act
            actualList = intListOne - intListTwo;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_IntsRemovingOnlythefirst1_ListOf351()
        {
            //Arrange
            CustomList<int> intListOne = new CustomList<int>() { 1,3,5,1};
            CustomList<int> intListTwo = new CustomList<int>() { 2,1,6};

            string expected = "351";
            CustomList<int> actualList;
            string actual = "";

            //Act
            actualList = intListOne - intListTwo;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_String_ListOfacd()
        {
            //Arrange
            CustomList<string> stringListOne = new CustomList<string>() { "a", "b", "c", "d"};
            CustomList<string> stringListTwo = new CustomList<string>() { "e", "e", "b"};

            string expected = "acd";
            CustomList<string> actualList;
            string actual;

            //Act
            actualList = stringListOne - stringListTwo;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_bool_ListOfTrue()
        {
            //Arrange
            CustomList<bool> stringListOne = new CustomList<bool>() { true, false, true };
            CustomList<bool> stringListTwo = new CustomList<bool>() { false, true };

            string expected = "True";
            CustomList<bool> actualList;
            string actual;

            //Act
            actualList = stringListOne - stringListTwo;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_DoublesWithMinusEquals_ListOf11135()
        {
            //Arrange
            CustomList<double> intListOne = new CustomList<double>() { 1.1, 3, 5, 1.0 };
            CustomList<double> intListTwo = new CustomList<double>() { 2.4, 1, 6, 1.9 };

            string expected = "1.135";
            string actual = "";

            //Act
            intListOne -= intListTwo;
            actual = intListOne.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
