using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int daysToStay = int.Parse(Console.ReadLine());
        String roomType = Console.ReadLine();
        String score = Console.ReadLine();

        double price = 0;
        double priceDiscount = 0;

        if ("room for one person".Equals(roomType))
        {
            price = 18.00 * (daysToStay - 1);
            priceDiscount = price;
        }
        else if ("apartment".Equals(roomType))
        {
            price = 25.0 * (daysToStay - 1);
            if (daysToStay < 10)
            {
                priceDiscount = price * 0.7;
            }
            else if (daysToStay <= 15)
            {
                priceDiscount = price * 0.65;
            }
            else
            {
                priceDiscount = price * 0.5;
            }
        }
        else if ("president apartment".Equals(roomType))
        {
            price = 35.00 * (daysToStay - 1);
            if (daysToStay < 10)
            {
                priceDiscount = price * 0.90;
            }
            else if (daysToStay <= 15)
            {
                priceDiscount = price * 0.85;
            }
            else
            {
                priceDiscount = price * 0.80;
            }
        }
        double totalPrice = 0.00;
        if ("positive".Equals(score))
        {
            totalPrice = priceDiscount + (priceDiscount * 0.25);

        }
        else if ("negative".Equals(score))
        {
            totalPrice = priceDiscount * 0.9;

        }
        Console.WriteLine("{0:F2}", totalPrice);
    }
}