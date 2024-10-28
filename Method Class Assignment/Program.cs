using System;

namespace Method_Class_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the 'MathOperations' class
            MathOperations mathOps = new MathOperations();

            // Call the 'PerformOperation' method, passing in two numbers
            mathOps.PerformOperation(8, 40);

            // Call the 'PerformOperation' method again, specifying the parameters by name
            mathOps.PerformOperation(num1: 3, num2: 50);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
