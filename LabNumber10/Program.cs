using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            int count = 0;
            
            while (runAgain)
            {                    
                Console.WriteLine("Welcome to the Circle Tester");
                double radius = Validator.GetDouble("Enter radius: ");
                Circle c = new Circle(radius);
                count++;
                Console.WriteLine("Circumference:\t" + c.CalculateFormattedCircumference());
                Console.WriteLine("Area:\t\t" + c.CalculateFormattedArea());
                runAgain = Validator.GetBool("Continue? (y/n): ", "y", "n");
            }

            Console.WriteLine($"Goodbye. You created {count} Circle object(s).");
        }
    }
}
