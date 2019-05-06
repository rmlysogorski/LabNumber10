using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber10
{
    class Validator
    {
        public static double GetDouble(string message = "Please enter a number: ", 
            string error = "Error - please enter a number: ")
        {
            Console.Write(message);
            if(!double.TryParse(Console.ReadLine(), out double number))
            {
                Console.WriteLine(error);
                return GetDouble(message, error);
            }
            else
            {
                return number;
            }
            
        }

        public static bool GetBool(string message, string opt1, string opt2)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if(input == string.Empty)
            {
                Console.WriteLine("Error - oops you forgot to type something!");
                return GetBool(message, opt1, opt2);
            }
            if(input == opt1)
            {
                return true;
            }
            if(input == opt2)
            {
                return false;
            }
            else
            {
                Console.WriteLine($"Please enter \"{opt1}\" for yes and " +
                    $"\"{opt2}\" for no. ");
                return GetBool(message, opt1, opt2);
            }
        }
    }
}
