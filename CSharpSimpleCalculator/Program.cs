using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2;
        string operation;
        string toContinue;

        while (true)
        {
            Console.WriteLine("Do math or exit application? Enter exit in case you want to exit application.");
            toContinue = Convert.ToString(Console.ReadLine());
            if (toContinue == "exit")
            {
                Environment.Exit(0);
            }

            Console.WriteLine("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter operation (+, -, *, /):");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
    }
}