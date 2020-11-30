using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class Sort
    {
        [TestMethod]
        public void Sort_PisitiveInt_ListOf12345()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>() { 5, 2, 3, 1, 4 };

            string expected = "12345";
            string actual = "";

            //Act
            intList.Sort();
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Sort_NegativeInt_ListOf5012345()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>() { 5, 2, 3,-5, 1, 4, 0 };

            string expected = "-5012345";
            string actual = "";

            //Act
            intList.Sort();
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Sort_PositiveAndNegativeDoubles_ListOfNumbers()
        {
            //Arrange
            CustomList<double> intList = new CustomList<double>() { 8, 0.4, 11.1, -2.4 };

            string expected = "-2.40.4811.1";
            string actual = "";

            //Act
            intList.Sort();
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Sort_CharList_ListOfbglp()
        {
            //Arrange
            CustomList<char> intList = new CustomList<char>() { 'b', 'p', 'l', 'g' };

            string expected = "bglp";
            string actual = "";

            //Act
            intList.Sort();
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Sort_StringList_ListOfGreetings()
        {
            //Arrange
            CustomList<string> intList = new CustomList<string>() { "Hi,", "Salut,", "Zdravstvuyte", "Guten Tag,"};

            string expected = "Guten Tag,Hi,Salut,Zdravstvuyte";
            string actual = "";

            //Act
            intList.Sort();
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Sort_PositiveInts_ListOfNumbers()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();

            string expected = "0135679121824";
            string actual = "";

            //Act
            for (int i = 0; i < 10; i++)
            {
                if((i % 2) >0)
                {
                    intList.Add(i);
                }
                else
                {
                    intList.Add(i*3);
                }
            }
            
            intList.Sort();
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
