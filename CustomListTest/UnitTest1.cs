﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_PostiveInteger_CountOfOne()
        {
            //Arrange
            CustomList<int> intList = new CustomList();
            int num1 = 9;
            int expected = 1;
            int actual;

            //Act
            intList.Add(num1);
            actual = intList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_NegativeInteger_CountOfThree()
        {
            //Arrange
            CustomList<int> intList = new CustomList();
            int num1 = -9;
            int num2 = -2;
            int num3 = -3;
            int expected = 3;
            int actual;

            //Act
            intList.Add(num1);
            intList.Add(num2);
            intList.Add(num3);
            actual = intList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_string_CountOfOne()
        {
            //Arrange
            CustomList<string> stringList = new CustomList();
            string blurb = "Sub Bro";
            int expected = 1;
            int actual;

            //Act
            stringList.Add(blurb);
            actual = stringList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_string_CapacityOfFour()
        {
            //Arrange
            CustomList<string> stringList = new CustomList();
            string blurb = "Sub Bro";
            string blurb2 = "Howdy";
            string blurb3 = "Hi Cutie";
            int expected = 4;
            int actual;

            //Act
            stringList.Add(blurb);
            stringList.Add(blurb2);
            stringList.Add(blurb3);
            actual = stringList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_Bool_CapacityOfEight()
        {
            CustomList<string> boolList = new CustomList();
            bool answer1 = true;
            bool answer2 = true;
            bool answer3 = false;
            bool answer4 = true;
            bool answer5 = false;
            int expected = 8;
            int actual;

            //Act
            boolList.Add(answer1);
            boolList.Add(answer2);
            boolList.Add(answer3);
            boolList.Add(answer4);
            boolList.Add(answer5);
            actual = boolList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Bool_LastAddIsFalse()
        {
            CustomList<string> boolList = new CustomList();
            bool answer1 = true;
            bool answer2 = true;
            bool answer3 = false;
            bool answer4 = true;
            bool answer5 = false;
            bool expected = false;
            bool actual;

            //Act
            boolList.Add(answer1);
            boolList.Add(answer2);
            boolList.Add(answer3);
            boolList.Add(answer4);
            boolList.Add(answer5);
            actual = boolList[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
