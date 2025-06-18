using System;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Value: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another Value: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator: ");
            String op = Console.ReadLine();
            
                if (op == "+")
                {
                    Console.WriteLine("Sum = " + (num1 + num2));
                }

                else if (op == "-")
                {
                    Console.WriteLine("Sum = " + (num1 - num2));
                }

                else if (op == "/")
                {
                    Console.WriteLine("Sum = " + (num1 / num2));
                }

                else if (op == "*")
                {
                    Console.WriteLine("Sum = " + (num1 * num2));
                }

                else if (op == "%")
                {
                    Console.WriteLine("Sum = " + (num1 % num2));
                }
        }

    }
}
