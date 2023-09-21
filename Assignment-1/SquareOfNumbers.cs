using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class SquareOfNumbers
    {
        public SquareOfNumbers(double a, double b)
        {
            double sumSquared = CalculateSquareOfSum(a, b); 
            Console.WriteLine($"Square of the sum: {sumSquared}"); 

            
            double diffSquared = CalculateSquareOfDifference(a, b); 
            Console.WriteLine($"Square of the difference: {diffSquared}"); 
        }

        
        static double CalculateSquareOfSum(double num1, double num2)
        {
            double sum = num1 + num2; // Calculate the sum of the two numbers
            return sum * sum; // Calculate and return the square of the sum
        }

        
        static double CalculateSquareOfDifference(double num1, double num2)
        {
            double difference = num1 - num2; // Calculate the difference between the two numbers
            return difference * difference; // Calculate and return the square of the difference
        }

    }
}

