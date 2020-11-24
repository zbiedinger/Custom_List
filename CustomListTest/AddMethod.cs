using System;
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
            CustomList<int> intList = new CustomList<int>();
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
            CustomList<int> intList = new CustomList<int>();
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
        public void Add_PostiveInteger_CountOfNine()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            int num1 = 2;
            int num2 = 2;
            int num3 = 2;
            int num4 = 2;
            int num5 = 2;
            int num6 = 2;
            int num7 = 2;
            int num8 = 2;
            int num9 = 2;

            int expected = 9;
            int actual;

            //Act
            intList.Add(num1);
            intList.Add(num2);
            intList.Add(num3);
            intList.Add(num4);
            intList.Add(num5);
            intList.Add(num6);
            intList.Add(num7);
            intList.Add(num8);
            intList.Add(num9);
            actual = intList.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_string_CountOfOne()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();
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
            CustomList<string> stringList = new CustomList<string>();
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
        public void Add_string_HowdyIsSecond()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();
            string blurb = "Sub Bro";
            string blurb2 = "Howdy";
            string blurb3 = "Hi Cutie";
            string blurb4 = "Hi";
            string blurb5 = "Yo";
            string expected = "Howdy";
            string actual;

            //Act
            stringList.Add(blurb);
            stringList.Add(blurb2);
            stringList.Add(blurb3);
            stringList.Add(blurb4);
            stringList.Add(blurb5);
            actual = stringList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Bool_CapacityOfEight()
        {
            CustomList<bool> boolList = new CustomList<bool>();
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
            CustomList<bool> boolList = new CustomList<bool>();
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
