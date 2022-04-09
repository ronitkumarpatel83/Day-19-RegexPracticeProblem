﻿using System;
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
                Console.WriteLine("The First name is : " +FirstName);
            }
            else
            {
                Console.WriteLine("Invalid Name : "+FirstName);
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
    }
}
