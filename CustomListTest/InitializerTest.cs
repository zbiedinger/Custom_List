using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListZ;

namespace CustomListTest
{
    [TestClass]
    public class InitializerTest
    {
        [TestMethod]
        public void Initializer_intsAddedInitializer_CountOffour()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>() { 1, 2, 3, 4 };

            int expected = 4;
            int actual;

            //Act
            actual = intList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Initializer_StringAddedInitializer_ListOfabc()
        {
            //Arrange
            CustomList<string> actualList = new CustomList<string>() { "a", "b", "c" };

            string expected = "abc";
            string actual;

            //Act
            actual = actualList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Initializer_MultipleListsInitialized_ListOfTrueFalseSupBro()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>() { "Sub", "Bro" };
            CustomList<bool> boolList = new CustomList<bool>() { true, false };

            string expected = "TrueFalseSubBro";
            string actual;

            //Act
            actual = boolList.ToString() + stringList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
