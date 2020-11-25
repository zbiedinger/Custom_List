using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class ZipMethod
    {


        [TestMethod]
        public void Zip_negativeInts_ListOf12()
        {
            //Arrange
            int num1 = -1;
            int num4 = -2;
            string expected = "-1-2";
            CustomList<int> actualList = new CustomList<int>();

            //Act
            actualList.Add(num1);
            actualList.Add(num4);

            string actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }


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

            string expected = "123456";
            CustomList<int> actualList;
            string actual;

            //Act
            intListOne.Add(num1);
            intListOne.Add(num2);
            intListOne.Add(num3);
            intListTwo.Add(num4);
            intListTwo.Add(num5);
            intListTwo.Add(num6);

            actualList = intListOne.Zip(intListTwo);
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_IntListOfDifferntSize_ListOf1234567()
        {
            CustomList<int> intListSmall = new CustomList<int>();
            CustomList<int> intListBig = new CustomList<int>();
            int num1 = 1;
            int num2 = 3;
            int num3 = 5;
            int num4 = 2;
            int num5 = 4;
            int num6 = 6;
            int num7 = 7;

            string expected = "1234567";
            CustomList<int> actualList;
            string actual;

            //Act
            intListSmall.Add(num1);
            intListSmall.Add(num2);
            intListSmall.Add(num3);
            intListBig.Add(num4);
            intListBig.Add(num5);
            intListBig.Add(num6);
            intListBig.Add(num7);

            actualList = intListSmall.Zip(intListBig);
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_bool_ListOfTFTFTF()
        {
            CustomList<bool> boolListOne = new CustomList<bool>();
            CustomList<bool> boolListTwo = new CustomList<bool>();
            bool truth1 = true;
            bool truth2 = true;
            bool truth3 = true;
            bool truth4 = false;
            bool truth5 = false;
            bool truth6 = false;

            string expected = "TrueFalseTrueFalseTrueFalse";
            CustomList<bool> actualList;
            string actual;

            //Act
            boolListOne.Add(truth1);
            boolListOne.Add(truth2);
            boolListOne.Add(truth3);
            boolListTwo.Add(truth4);
            boolListTwo.Add(truth5);
            boolListTwo.Add(truth6);

            actualList = boolListOne.Zip(boolListTwo);
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_stringListOfDifferntSize_ListOfABCDE()
        {
            CustomList<string> stringListBig = new CustomList<string>();
            CustomList<string> stringListSmall = new CustomList<string>();
            string letter = "A";
            string letter2 = "B";
            string letter3 = "C";
            string letter4 = "D";
            string letter5 = "E";

            string expected = "ABCDE";
            CustomList<string> actualList;
            string actual;

            //Act
            stringListBig.Add(letter);
            stringListBig.Add(letter3);
            stringListBig.Add(letter5);
            stringListSmall.Add(letter2);
            stringListSmall.Add(letter4);


            actualList = stringListBig.Zip(stringListSmall);
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_EmptyStringSecond_NoListMade()
        {
            CustomList<string> stringListBig = new CustomList<string>();
            CustomList<string> stringListSmall = new CustomList<string>();
            string letter = "A";
            string letter2 = "C";

            string expected = "AC";
            CustomList<string> actualList;
            string actual;

            //Act
            stringListBig.Add(letter);
            stringListBig.Add(letter2);

            actualList = stringListBig.Zip(stringListSmall);
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_EmptyStringFirst_NoListMade()
        {
            CustomList<string> stringListBig = new CustomList<string>();
            CustomList<string> stringListSmall = new CustomList<string>();
            string letter = "A";
            string letter2 = "C";

            string expected = "AC";
            CustomList<string> actualList;
            string actual;

            //Act
            stringListBig.Add(letter);
            stringListBig.Add(letter2);

            actualList = stringListSmall.Zip(stringListBig);
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
