using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, this is the Calculator Program");
            Console.WriteLine("Press anything to continue...");
            Console.ReadKey();
            Console.Clear();

            int gate = 0;

            while (gate == 0)
            {
                Console.Clear();

                double answer = 0.00;

                Console.WriteLine("What is your first number?");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("What is your second number?");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("What is your operator? (+, -, /, *)");

                string operator1 = Console.ReadLine();

                switch (operator1)
                {
                    case "+":
                        answer = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + answer);
                        break;
                    case "-":
                        answer = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + answer);
                        break;
                    case "/":
                        answer = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + answer);
                        break;
                    case "*":
                        answer = num1 * num2;
                        Console.WriteLine(num1 + " * " + num2 + " = " + answer);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Try again? y/n");
                var try1 = Console.ReadLine();

                if (try1 == "n")
                {
                    Console.WriteLine("Thanks for using me!");
                    gate = 1;
                }
            }
        }
    }
}
