using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;


namespace CustomListTest
{
    [TestClass]
    public class PlusOverload
    {
        [TestMethod]
        public void PlusOperator_positiveInts_ListOf135246()
        {
            CustomList<int> intListOne = new CustomList<int>();
            CustomList<int> intListTwo = new CustomList<int>();
            int num1 = 1;
            int num2 = 3;
            int num3 = 5;
            int num4 = 2;
            int num5 = 4;
            int num6 = 6;

            int[] expected = new int[] { 1, 3, 5, 2, 4, 6 };
            CustomList<int> actual;

            //Act
            intListOne.Add(num1);
            intListOne.Add(num2);
            intListOne.Add(num3);
            intListTwo.Add(num4);
            intListTwo.Add(num5);
            intListTwo.Add(num6);

            actual = intListOne + intListTwo;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_IntsDifferentSize_ListOf1352()
        {
            CustomList<int> intListBig = new CustomList<int>();
            CustomList<int> intListSmall = new CustomList<int>();
            int num1 = 1;
            int num2 = 3;
            int num3 = 5;
            int num4 = 2;

            int[] expected = new int[] { 1, 3, 5, 2, 4, 6 };
            CustomList<int> actual;

            //Act
            intListBig.Add(num1);
            intListBig.Add(num2);
            intListBig.Add(num3);
            intListSmall.Add(num4);
            

            actual = intListBig + intListSmall;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_CharDifferentSize_ListOftigger()
        {
            CustomList<char> intListBig = new CustomList<char>();
            CustomList<char> intListSmall = new CustomList<char>();
            char letter1 = 't';
            char letter2 = 'i';
            char letter3 = 'g';
            char letter4 = 'e';
            char letter5 = 't';

            string expected = "tigger";
            CustomList<char> actualList;
            string actual = "";

            //Act
            intListSmall.Add(letter1);
            intListSmall.Add(letter2);
            intListBig.Add(letter3);
            intListBig.Add(letter3);
            intListBig.Add(letter4);
            intListBig.Add(letter5);
 
            actualList = intListSmall + intListBig;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_threestringlist_ListOfRowYourBoat()
        {
            CustomList<string> stringListRow = new CustomList<string>();
            CustomList<string> stringListRest = new CustomList<string>();
            CustomList<string> stringListMerrily = new CustomList<string>();

            string word1 = "Row ";
            string word2 = "your boat. ";
            string word3 = "Gently ";
            string word4 = "down ";
            string word5 = "the stream. ";
            string word6 = "Merrily ";

            string expected = "Row Row Row your boat. Gently down the stream. Merrily Merrily Merrily Merrily ";
            CustomList<string> actualList;
            string actual;

            //Act
            stringListRow.Add(word1);
            stringListRow.Add(word1);
            stringListRow.Add(word1);

            stringListRest.Add(word2);
            stringListRest.Add(word3);
            stringListRest.Add(word4);
            stringListRest.Add(word5);

            stringListMerrily.Add(word6);
            stringListMerrily.Add(word6);
            stringListMerrily.Add(word6);
            stringListMerrily.Add(word6);

            actualList = stringListRow + stringListRest + stringListMerrily;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlusOperator_BoolLists_ListOfRowYourBoat()
        {
            //Arrange
            CustomList<bool> boolListTrue = new CustomList<bool>();
            CustomList<bool> boolListFalse = new CustomList<bool>();
            bool truthT = true;
            bool truthF = false;


            string expected = "TrueTrueFalseFalse";
            CustomList<bool> actualList;
            string actual;

            //Act
            boolListTrue.Add(truthT);
            boolListTrue.Add(truthT);
            boolListFalse.Add(truthF);
            boolListFalse.Add(truthF);

            actualList = boolListTrue + boolListFalse;
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
