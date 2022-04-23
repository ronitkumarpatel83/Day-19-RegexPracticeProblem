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
        /// <summary>
        /// Emails the validation.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="expected">The expected.</param>
        [TestMethod]
        //Checking for multiple email samples that are valid
        [DataRow("abc@gmail.com", "Valid")]
        [DataRow("abc-100@yahoo.com", "Valid")]
        [DataRow("abc.100@yahoo.com", "Valid")]
        [DataRow("abc@1.com", "Valid")]
        [DataRow("abc111@yahoo.com.au", "Valid")]
        [DataRow("abc-100@yahoo.com.au", "Valid")]
        [DataRow("abc@gmail.com.com", "Valid")]
        [DataRow("abc+100@yahoo.com", "Valid")]
        //Checking for multiple email samples that are Invalid
        [DataRow("abc", "Invalid")]
        [DataRow("abc@.com.my", "Invalid")]
        [DataRow("abc123@gmail.a", "Invalid")]
        [DataRow("abc123@.com", "Invalid")]
        [DataRow("abc@.com.com", "Invalid")]
        [DataRow(".abc@abc.com", "Invalid")]
        [DataRow("abc()*@gmail.com", "Invalid")]
        [DataRow("abc@%*.com", "Invalid")]
        [DataRow("abc..2002@gmail.com", "Invalid")]
        [DataRow("abc.@gmail.com", "Invalid")]
        [DataRow("abc@abc@gmail.com", "Invalid")]
        [DataRow("abc@gmail.com.1a", "Invalid")]
        [DataRow("abc@gmail.com.aa.au", "Invalid")]
        public void EmailValidation(string email,string expected)
        {
            //Act
            string actual = Validation.EmailValidation(email);
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
