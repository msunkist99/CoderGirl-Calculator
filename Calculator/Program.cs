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

            Console.WriteLine("1 - add " + firstNumber + " and " + secondNumber);
            Console.WriteLine("2 - subtract " + firstNumber + " from " + secondNumber);
            Console.WriteLine("3 - subtract " + secondNumber + " from " + firstNumber);
            Console.WriteLine("4 - multiply " + firstNumber + " and " + secondNumber);
            Console.WriteLine("5 - divide " + firstNumber + " by " + secondNumber);
            Console.WriteLine("6 - divide " + secondNumber + " by " + firstNumber);
            Console.WriteLine("enter your option for the numbers - ");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                result = firstNumber + secondNumber;
            }
            else if (option == 2)
            {
                result = secondNumber - firstNumber;
            }
            else if (option == 3)
            {
                result = firstNumber - secondNumber;
            }
            else if (option == 4)
            {
                result = firstNumber * secondNumber;
            }
            else if (option == 5)
            {
                result = firstNumber / secondNumber;
            }
            else if (option == 6)
            {
                result = secondNumber / firstNumber;
            }

            Console.WriteLine($"Total = {result:0.00}");

            Console.ReadLine();
        }
    }
}
