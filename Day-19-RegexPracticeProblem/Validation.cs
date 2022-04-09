using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_19_RegexPracticeProblem
{
    internal class Validation
    {
        public static void FirstNameValidation(string FirstName)
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
            if (Regex.IsMatch(FirstName, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("The First name is : " + FirstName);
            }
            else
            {
                Console.WriteLine("Invalid Name : " + FirstName);
            }
        }
        public static void LastNameValidation(string LastName)
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
            if (Regex.IsMatch(LastName, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("The First name is : " + LastName);
            }
            else
            {
                Console.WriteLine("Invalid Name : " + LastName);
            }
        }
        public static void EmailValidation(string Email)
        {
            string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Creating REGEX pattern
            if (Regex.IsMatch(Email, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("My email id is : " + Email);
            }
            else
            {
                Console.WriteLine("Invalid email : " + Email);
            }
        }
        public static void MobileNumberValidation(string Number)
        {
            string pattern = "^[0-9]{1,3}[ ][0-9]{10}$"; // Creating REGEX pattern
            if (Regex.IsMatch(Number, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("My number id is : " + Number);
            }
            else
            {
                Console.WriteLine("Invalid number : " + Number);
            }
        }
        public static void Password(string pswd)
        {
            string pattern = "^.*(?=.{8,})(?=.*d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$"; // Creating REGEX pattern
            if (Regex.IsMatch(pswd, pattern)) //For checking regex are valid or invalid
            {
                Console.WriteLine("My password id is : " + pswd);
            }
            else
            {
                Console.WriteLine("Invalid password : " + pswd);
            }
        }
    }
}
