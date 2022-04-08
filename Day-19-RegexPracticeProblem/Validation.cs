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
            if (Regex.IsMatch(FirstName, pattern))
            {
                Console.WriteLine("The First name is : " +FirstName);
            }
            else
            {
                Console.WriteLine("Invalid Name : "+FirstName);
            }
        }
    }
}
