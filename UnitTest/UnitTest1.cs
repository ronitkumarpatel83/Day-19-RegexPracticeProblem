using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_19_RegexPracticeProblem;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Checking for multiple first name
        [DataRow("kkkkk", "Invalid")]
        [DataRow("RKP", "Invalid")]
        [DataRow("Ronit", "Valid")]
        public void GivenFirstNameValidation(string firstName, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                string actual = Validation.FirstNameValidation(firstName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("kkkkk", "Invalid")]
        [DataRow("RKP", "Invalid")]
        [DataRow("Patel", "Valid")]
        public void GivenLastNameValidation(string lastName, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                string actual = Validation.LastNameValidation(lastName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
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
            try
            {
                //Act
                string actual = Validation.EmailValidation(email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        [DataRow("5486514965", "Invalid")]
        [DataRow("91 7008427274", "Valid")]
        [DataRow("54863546564", "Invalid")]
        public void MobileNumber(string number, string expected)
        {
            try
            {
                //Act
                string actual = Validation.MobileNumberValidation(number);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch(CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [TestMethod]
        [DataRow("PassWord@1342","Valid")]
        [DataRow("PassWord2324", "Invalid")]
        [DataRow("PassWord", "Invalid")]
        public void Password(string pass, string expected)
        {
            try
            {
                //Act
                string actual = Validation.Password(pass);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch(CustomException ex)
            {
                Assert.AreEqual (expected, ex.Message);
            }
        }
    }
}
