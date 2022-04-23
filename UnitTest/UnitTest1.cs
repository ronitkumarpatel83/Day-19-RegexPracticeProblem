using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_19_RegexPracticeProblem;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstName()
        {
            //Arrange
            string expected = "Valid";
            string massage = "Ronit";
            //Act
            string actual = Validation.FirstNameValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void LastName()
        {
            //Arrange
            string expected = "Valid";
            string massage = "Patel";
            //Act
            string actual = Validation.LastNameValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void EmailValidation()
        {
            //Arrange
            string expected = "Valid";
            string massage = "ronitkumatpatel83@gmail.com";
            //Act
            string actual = Validation.EmailValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void MobileNumber()
        {
            //Arrange
            string expected = "Valid";
            string massage = "91 7008427274";
            //Act
            string actual = Validation.MobileNumberValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Password()
        {
            //Arrange
            string expected = "Valid";
            string massage = "India@12345";
            //Act
            string actual = Validation.Password(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
