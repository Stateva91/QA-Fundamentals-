using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());

        switch (operation)
        {
            case '+':
                int sum = number1 + number2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", number1, number2, sum);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", number1, number2, sum);
                }
                break;
            case '-':
                int div = number1 - number2;
                if (div % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", number1, number2, div);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", number1, number2, div);
                }
                break;
            case '*':
                int product = number1 * number2;
                if (product % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", number1, number2, product);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", number1, number2, product);
                }
                break;
            case '/':
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    double division = number1 * 1.0 / number2;
                    Console.WriteLine("{0} / {1} = {2:F2}", number1, number2, division);
                }
                break;
            case '%':
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    int leftover = number1 % number2;
                    Console.WriteLine("{0} %% {1} = {2}", number1, number2, leftover);
                }
                break;
        }
    }
}