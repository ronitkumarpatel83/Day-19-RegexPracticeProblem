using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_19_RegexPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Regular Expression");
            //Console.WriteLine("Enter your first name");
            //string FirstName = Console.ReadLine(); // Creating user input for first name
            //Validation.FirstNameValidation(FirstName);////Calling method to validate firstname

            //Console.WriteLine("Enter your last name");
            //string LastName = Console.ReadLine(); // Creating user input for last name
            //Validation.LastNameValidation(LastName);////Calling method to validate lastname

            //Console.WriteLine("Valid email are :");
            //// string Email = Console.ReadLine(); // Creating user input for last name
            //string[] emailarr = {"abc@gmail.com", "abc-100@yahoo.com", "abc.100@yahoo.com","abc@1.com","abc111@yahoo.com.au", "abc-100@yahoo.com.au", "abc@gmail.com.com", "abc+100@yahoo.com" };
            //foreach (string email in emailarr)
            //{
            //    Validation.EmailValidation(email);////Calling method to validate lastname
            //}
            //Console.WriteLine("\nInvalid email are :\n");
            //string[] emailinvalid = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            //foreach (string emails in emailinvalid)
            //{
            //   Validation.EmailValidation(emails);
            //}

            Console.WriteLine("Enter your mobile Number with country code : ");
            string number = Console.ReadLine(); // Creating user input for last name
            Validation.MobileNumberValidation(number);////Calling method to validate lastname
        }
    }
}
