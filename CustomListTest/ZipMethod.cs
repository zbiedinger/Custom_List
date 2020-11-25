using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class ZipMethod
    {
        [TestMethod]
        public void Zip_positiveInts_ListOf123456()
        {
            CustomList<int> intListOne = new CustomList<int>();
            CustomList<int> intListTwo = new CustomList<int>();
            int num1 = 1;
            int num2 = 3;
            int num3 = 5;
            int num4 = 2;
            int num5 = 4;
            int num6 = 6;

            int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };
            CustomList<int> actual;

            //Act
            intListOne.Add(num1);
            intListOne.Add(num2);
            intListOne.Add(num3);
            intListTwo.Add(num4);
            intListTwo.Add(num5);
            intListTwo.Add(num6);

            actual = intListOne.Zip(intListTwo);

            ////Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_IntListOfDifferntSize_ListOf1234567()
        {
            CustomList<int> intListOne = new CustomList<int>();
            CustomList<int> intListTwo = new CustomList<int>();
            int num1 = 1;
            int num2 = 3;
            int num3 = 5;
            int num4 = 2;
            int num5 = 4;
            int num6 = 6;
            int num7 = 7;

            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            CustomList<int> actual;

            //Act
            intListOne.Add(num1);
            intListOne.Add(num2);
            intListOne.Add(num3);
            intListTwo.Add(num4);
            intListTwo.Add(num5);
            intListTwo.Add(num6);
            intListTwo.Add(num7);

            actual = intListOne.Zip(intListTwo);

            ////Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_stringListOfDifferntSize_ListOfABCDE()
        {
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            string letter = "A";
            string letter2 = "B";
            string letter3 = "C";
            string letter4 = "D";
            string letter5 = "E";

            string[] expected = new string[] { "A", "B", "C", "D", "E" };
            CustomList<string> actual;

            //Act
            stringListOne.Add(letter);
            stringListOne.Add(letter3);
            stringListOne.Add(letter5);
            stringListTwo.Add(letter2);
            stringListTwo.Add(letter4);


            actual = stringListOne.Zip(stringListTwo);

            ////Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_DifferentListTypes_NoListMade()
        {
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<int> stringListTwo = new CustomList<int>();
            string letter = "A";
            int num1 = 8;
            string letter3 = "C";
            int num2 = 4;
            string letter5 = "E";

            string[] expected = new string[] {null};
            CustomList<string> actual;

            //Act
            stringListOne.Add(letter);
            stringListOne.Add(letter3);
            stringListOne.Add(letter5);
            stringListTwo.Add(num1);
            stringListTwo.Add(num2);


            actual = stringListOne.Zip(stringListTwo);

            ////Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
