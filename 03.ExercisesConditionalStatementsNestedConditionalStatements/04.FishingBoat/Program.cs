internal class Program
{
    private static void Main(string[] args)
    {
        int budget = int.Parse(Console.ReadLine());
        String season = Console.ReadLine();
        int fishermen = int.Parse(Console.ReadLine());

        double price = 0;
        double SpringPrice = 3000;
        double SummerAutumnPrice = 4200;
        double WinterPrice = 2600;
        if (fishermen <= 6)
        {
            if ("Spring".Equals(season))
            {
                price = SpringPrice * 0.90;

            }
            else if ("Summer".Equals(season) || "Autumn".Equals(season))
            {
                price = SummerAutumnPrice * 0.90;
            }
            else if ("Winter".Equals(season))
            {
                price = WinterPrice * 0.90;
            }
        }
        else if (fishermen <= 11)
        {
            if ("Spring".Equals(season))
            {
                price = SpringPrice * 0.85;
            }
            else if ("Summer".Equals(season) || "Autumn".Equals(season))
            {
                price = SummerAutumnPrice * 0.85;
            }
            else if ("Winter".Equals(season))
            {
                price = WinterPrice * 0.85;
            }
        }
        else if (fishermen > 12)
        {
            if ("Spring".Equals(season))
            {
                price = SpringPrice * 0.75;
            }
            else if ("Summer".Equals(season) || "Autumn".Equals(season))
            {
                price = SummerAutumnPrice * 0.75;
            }
            else if ("Winter".Equals(season))
            {
                price = WinterPrice * 0.75;
            }
        }
        if (fishermen % 2 == 0 && !(season.Equals("Autumn")))
        {
            price = price * 0.95;
        }
        double result = budget - price;
        if (result >= 0)
        {
            Console.WriteLine("Yes! You have {0:F2} leva left.", result);
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:F2} leva.", -result);
        }
    }
}