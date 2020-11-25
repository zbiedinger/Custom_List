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

            //actual = intListOne + intListTwo;

            ////Assert
            //Assert.AreEqual(expected, actual);
        }
    }
}
