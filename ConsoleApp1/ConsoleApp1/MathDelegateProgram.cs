using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Define a delegate
    public delegate int MathOperation(int a, int b);
    public class MathDelegateProgram
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
        }

        public void PerformMathOperation(string operationName, MathOperation operation)
        {
            Console.Write("Enter the first number: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.Write("Enter the second number: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    int result = operation(num1, num2);
                    Console.WriteLine($"{operationName} result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input for the second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the first number.");
            }
        }
    }
}
