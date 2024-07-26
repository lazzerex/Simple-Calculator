using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine("Addition: " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("Substraction: " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("Substraction: " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("Substraction: " + result);
                        break;
                    default:
                        Console.WriteLine("Wrong inputs");
                        break;
                }

                Console.WriteLine(" ");
                Console.Write("Do you want to continue (y/n): ");
                value = Console.ReadLine();

            }
            while (value == "y" || value == "Y");
        }
    }
}

