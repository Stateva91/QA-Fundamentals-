﻿internal class Program
{
    private static void Main(string[] args)
    {
        double change = Double.Parse(Console.ReadLine());
        double coins = change * 100;
        int counter = 0;
        while (coins != 0)
        {
            if (coins >= 200)
            {
                coins -= 200;
                counter++;
            }
            else if (coins >= 100)
            {
                coins -= 100;
                counter++;
            }
            else if (coins >= 50)
            {
                coins -= 50;
                counter++;
            }
            else if (coins >= 20)
            {
                coins -= 20;
                counter++;
            }
            else if (coins >= 10)
            {
                coins -= 10;
                counter++;
            }
            else if (coins >= 5)
            {
                coins -= 5;
                counter++;
            }
            else if (coins >= 2)
            {
                coins -= 2;
                counter++;
            }
            else if (coins >= 1)
            {
                coins -= 1;
                counter++;
            }
            else
            {
                break;
            }
        }
       Console.WriteLine(counter);
    }
}
