using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_19_RegexPracticeProblem
{
    public class Validation
    {
        static Func<string, string, bool> patternsMatching = (x, y) => Regex.IsMatch(x, y);
        public static string FirstNameValidation(string FirstName)
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
                if (patternsMatching(FirstName, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("The First name is : " + FirstName);
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Invalid");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public static string LastNameValidation(string LastName)
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
                if (patternsMatching(LastName, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("The First name is : " + LastName);
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Invalid");
                }
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public static string EmailValidation(string Email)
        {
            try
            {
                string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Creating REGEX pattern
                if (patternsMatching(Email, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("My email id is : " + Email);
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Invalid");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public static string MobileNumberValidation(string Number)
        {
            try
            {
                string pattern = "^[0-9]{1,3}[ ][0-9]{10}$"; // Creating REGEX pattern
                if (patternsMatching(Number, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("My number id is : " + Number);
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Invalid");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public static string Password(string pswd)
        {
            try
            {
                string pattern = "^((?=.{8,}$)(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9]{0,30}?[@~!#$%^&+*]{1}[a-zA-Z0-9]{0,30})$"; // Creating REGEX pattern

                if (patternsMatching(pswd, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("My password id is : " + pswd);
                    return "Valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Invalid");
                }
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}
