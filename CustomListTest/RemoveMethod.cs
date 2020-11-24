using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class RemoveMethod
    {
        [TestMethod]
        public void Remove_PostiveInteger_CountOfOne()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            int num1 = 9;
            int num2 = 2;
            int expected = 1;
            int actual;

            //Act
            intList.Add(num1);
            intList.Add(num2);
            intList.Remove(num1);
            actual = intList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_NegativeInteger_CountOftwo()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            int num1 = -9;
            int num2 = -2;
            int num3 = -3;
            int num4 = 3;
            int expected = 2;
            int actual;

            //Act
            intList.Add(num1);
            intList.Add(num2);
            intList.Add(num3);
            intList.Add(num4);
            intList.Remove(num2);
            intList.Remove(num4);
            actual = intList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_string_CountOfZero()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();
            string blurb = "Sub Bro";
            int expected = 0;
            int actual;

            //Act
            stringList.Add(blurb);
            stringList.Remove(blurb);
            actual = stringList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_string_TryToRemoveStringThatsNotThere()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();
            string blurb = "Sub Bro";
            string blurb2 = "Howdy";
            string blurb3 = "Hi Cutie";
            string blurb4 = "Hi";
            string blurb5 = "Yo";
            int expected = 4;
            int actual;

            //Act
            stringList.Add(blurb);
            stringList.Add(blurb2);
            stringList.Add(blurb3);
            stringList.Add(blurb4);
            stringList.Remove(blurb5);
            actual = stringList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_string_RemoveStringThatsNotThere()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();
            string blurb = "Sub Bro";
            string blurb2 = "Howdy";
            string blurb3 = "Hi Cutie";
            string blurb4 = "Hi";
            string blurb5 = "Yo";

            //Act
            stringList.Add(blurb);
            stringList.Add(blurb2);
            stringList.Add(blurb3);
            stringList.Add(blurb4);
            stringList.Remove(blurb5);

            //Assert
            Assert.IsFalse(stringList.Remove(blurb5));
        }

        //[TestMethod]
        //public void Remove_Bool_LastIsFalse()
        //{
        //    CustomList<bool> boolList = new CustomList<bool>();
        //    bool answer1 = true;
        //    bool answer2 = true;
        //    bool answer3 = false;
        //    bool answer4 = true;
        //    bool answer5 = false;
        //    bool expected = false;
        //    bool actual;

        //    //Act
        //    boolList.Add(answer1);
        //    boolList.Add(answer2);
        //    boolList.Add(answer3);
        //    boolList.Add(answer4);
        //    boolList.Add(answer5);
        //    boolList.Remove(answer4);
        //    boolList.Remove(answer3);
        //    actual = boolList[3];

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
