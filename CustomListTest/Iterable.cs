using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class Iterable
    {
        [TestMethod]
        public void Iterator_ForeachThroughIntList_StringOf1351()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>() { 1, 3, 5, 1 };

            string expected = "1351";
            string actual = "";

            //Act
            foreach (int num in intList)
            {
                actual += num.ToString();
            }
           
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterator_ForeachThroughIntListForEvens_StringOf246()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>() { 1, 2, 3, 4, 5, 6};

            string expected = "246";
            string actual = "";

            //Act
            foreach (int num in intList)
            {
                if(num%2 == 0)
                {
                    actual += num.ToString();
                }
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterator_ForeachThroughStringList_StringOfCatsRule()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>() { "Cats", " ", "don't", "rule" };

            string expected = "Cats rule";
            string actual = "";

            //Act
            foreach (string word in stringList)
            {
                if(word == "don't")
                {
                    continue;
                }
                else
                {
                    actual += word;
                }
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterator_DoubleAdded_SumOf45()
        {
            //Arrange
            CustomList<double> doubleList = new CustomList<double>() { 5.5, 3.2, 4, 11.3, 22.8 };


            double expected = 46.8;
            double actual = 0;

            //Act
            foreach (double num in doubleList)
            {
                actual += num;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Iterator_CharToString_StringOfKnitting()
        {
            //Arrange
            CustomList<char> charList = new CustomList<char>() { 'K', 'n', 'i', 't', 't', 'i', 'n', 'g' };

            string expected = "Knitting";
            string actual = "";

            //Act
            foreach (char letter in charList)
            {
                actual += letter;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
