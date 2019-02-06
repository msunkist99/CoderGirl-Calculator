using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            double result = 0;

            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 
            Console.WriteLine("enter your FIRST number - ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("enter your SECOND number - ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("add " + firstNumber + " and " + secondNumber);
            Console.WriteLine("subtract " + secondNumber + " from " + firstNumber);
            Console.WriteLine("multiply " + firstNumber + " and " + secondNumber);
            Console.WriteLine("divide " + secondNumber + " by " + firstNumber);
            Console.WriteLine("enter your option for the numbers - ");

            string option = Console.ReadLine();

            if (option == "add")
            {
                result = firstNumber + secondNumber;
            }
            else if (option == "subtract")
            {
                result = firstNumber - secondNumber;
            }

            else if (option == "multiply")
            {
                result = firstNumber * secondNumber;
            }
            else if (option == "divide")
            {
                result = firstNumber / secondNumber;
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
