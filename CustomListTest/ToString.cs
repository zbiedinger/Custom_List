using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class ToString
    {
        [TestMethod]
        public void ToString_PositiveInt_StringOf12351()
        {
            CustomList<int> intList = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 5;
            int num5 = 1;

            string expected = "12351";
            string actual;

            //Act
            intList.Add(num1);
            intList.Add(num2);
            intList.Add(num3);
            intList.Add(num4);
            intList.Add(num5);
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_char_StringOfWOW()
        {
            CustomList<char> intList = new CustomList<char>();
            char num1 = 'W';
            char num2 = 'O';
            char num3 = 'W';

            string expected = "WOW";
            string actual;

            //Act
            intList.Add(num1);
            intList.Add(num2);
            intList.Add(num3);
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_bools_StringOftrue()
        {
            CustomList<bool> boolList = new CustomList<bool>();
            bool num1 = true;
            bool num2 = true;
            bool num3 = true;
            bool num4 = false;

            string expected = "TrueTrueTrueFalse";
            string actual;

            //Act
            boolList.Add(num1);
            boolList.Add(num2);
            boolList.Add(num3);
            boolList.Add(num4);

            actual = boolList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ToString_string_StringOfHappyFriday()
        {
            CustomList<string> intList = new CustomList<string>();
            string num1 = "Happy ";
            string num2 = "Friday";

            string expected = "Happy Friday";
            string actual;

            //Act
            intList.Add(num1);
            intList.Add(num2);
            actual = intList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
