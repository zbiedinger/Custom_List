using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class Indexer
    {
        [TestMethod]
        public void Indexer_PositiveInt_FirstIndexIsFive()
        {
            CustomList<int> intList = new CustomList<int>();
            int num1 = 5;

            int expected = 5;
            int actual;

            //Act
            intList.Add(num1);
            actual = intList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_PositiveInt_ThirdIndexIsSix()
        {
            CustomList<int> intList = new CustomList<int>();
            int num1 = 5;
            int num2 = -2;
            int num3 = 6;
            int num4 = 3;

            int expected = 6;
            int actual;

            //Act
            intList.Add(num1);
            intList.Add(num2);
            intList.Add(num3);
            intList.Add(num4);
            actual = intList[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_String_SecondIndexIsHowdy()
        {
            CustomList<string> stringtList = new CustomList<string>();
            string blurb = "Sub Bro";
            string blurb2 = "Howdy";
            string blurb3 = "Hi Cutie";
            string blurb4 = "Hello";

            string expected = "Howdy";
            string actual;

            //Act
            stringtList.Add(blurb);
            stringtList.Add(blurb2);
            stringtList.Add(blurb3);
            stringtList.Add(blurb4);
            actual = stringtList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_StringsRemoved_SecondIndexIsHi()
        {
            //Arrange
            CustomList<string> stringtList = new CustomList<string>();
            string blurb = "Sub Bro";
            string blurb2 = "Howdy";
            string blurb3 = "Hi Cutie";
            string blurb4 = "Hi";
            string blurb5 = "Yo";

            string expected = "Hi";
            string actual;

            //Act
            stringtList.Add(blurb);
            stringtList.Add(blurb2);
            stringtList.Add(blurb3);
            stringtList.Add(blurb4);
            stringtList.Add(blurb5);
            stringtList.Remove(blurb);
            stringtList.Remove(blurb3);
            actual = stringtList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_BoolsRemoved_SecondIndexIsFalse()
        {
            //Arrange
            CustomList<bool> boolList = new CustomList<bool>();
            bool answer1 = true;
            bool answer2 = true;
            bool answer3 = false;
            bool answer4 = true;
            bool answer5 = false;
            bool expected = true;
            bool actual;

            //Act
            boolList.Add(answer1);
            boolList.Add(answer2);
            boolList.Add(answer3);
            boolList.Add(answer4);
            boolList.Add(answer5);
            boolList.Remove(answer1);
            boolList.Remove(answer4);
            actual = boolList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //check outside the count of the list
        [TestMethod]
        public void Indexer_positiveInt_OutOfBoundsCheck()
        {
            CustomList<int> intList = new CustomList<int>();
            int num1 = 5;

            int expected = 0;
            int actual;

            //Act
            intList.Add(num1);
            //actual = intList[1];

            //Assert
            Assert.Fail("Index out of range", intList[1].ToString());
        }
    }
}
