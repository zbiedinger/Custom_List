using System;
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
            CustomList<int> intListTwo = new CustomList<int>();
            CustomList<int> intListOne = new CustomList<int>();

            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num5 = 5;
            int num6 = 6;

            string expected = "35";
            CustomList<int> actualList;
            string actual = "";

            //Act
            intListOne.Add(num1);
            intListOne.Add(num3);
            intListOne.Add(num5);
            intListTwo.Add(num2);
            intListTwo.Add(num1);
            intListTwo.Add(num6);

            actualList = intListOne - intListTwo;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_PositiveIntsRemoving2num_ListOf358()
        {
            //Arrange
            CustomList<int> intListTwo = new CustomList<int>();
            CustomList<int> intListOne = new CustomList<int>();

            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num5 = 5;
            int num6 = 6;
            int num8 = 8;

            string expected = "35";
            CustomList<int> actualList;
            string actual = "";

            //Act
            intListOne.Add(num1);
            intListOne.Add(num3);
            intListOne.Add(num5);
            intListOne.Add(num8);
            intListTwo.Add(num2);
            intListTwo.Add(num1);
            intListTwo.Add(num6);
            intListTwo.Add(num8);


            actualList = intListOne - intListTwo;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MinusOperator_IntsRemovingonlythefirst1_ListOf358()
        {
            //Arrange
            CustomList<int> intListTwo = new CustomList<int>();
            CustomList<int> intListOne = new CustomList<int>();

            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num5 = 5;
            int num6 = 6;

            string expected = "35";
            CustomList<int> actualList;
            string actual = "";

            //Act
            intListOne.Add(num1);
            intListOne.Add(num3);
            intListOne.Add(num5);
            intListOne.Add(num1);
            intListTwo.Add(num2);
            intListTwo.Add(num1);
            intListTwo.Add(num6);


            actualList = intListOne - intListTwo;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
