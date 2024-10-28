using System;

namespace Method_Class_Assignment
{
    public class MathOperations
    {
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer
            int result = num1 * 5;

            // Display the result of the operation
            Console.WriteLine($"The result of multiplying {num1} by 5 is: {result}");

            // Display the second integer
            Console.WriteLine($"The second integer is: {num2}");
        }
    }
}
