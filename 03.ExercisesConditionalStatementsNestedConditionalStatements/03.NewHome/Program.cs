internal class Program
{
    private static void Main(string[] args)
    {
        String flowers = Console.ReadLine();
        int countFlowers = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double price = 0;
        double priceFlowersRoses = countFlowers * 5.00;
        double priceFlowersDahlias = countFlowers * 3.80;
        double priceFlowersTulips = countFlowers * 2.80;
        double priceFlowersNarcissus = countFlowers * 3.00;
        double priceFlowersGladiolus = countFlowers * 2.50;
        if ("Roses".Equals(flowers))
        {
            if (countFlowers > 80)
            {
                price = priceFlowersRoses * 0.90;
            }
            else
            {
                price = priceFlowersRoses;
            }
        }
        else if ("Dahlias".Equals(flowers))
        {
            if (countFlowers > 90)
            {
                price = priceFlowersDahlias * 0.85;
            }
            else
            {
                price = priceFlowersDahlias;
            }
        }
        else if ("Tulips".Equals(flowers))
        {
            if (countFlowers > 80)
            {
                price = priceFlowersTulips * 0.85;
            }
            else
            {
                price = priceFlowersTulips;
            }
        }
        else if ("Narcissus".Equals(flowers))
        {
            if (countFlowers < 120)
            {
                price = (priceFlowersNarcissus * 0.15) + priceFlowersNarcissus;
            }
            else
            {
                price = priceFlowersNarcissus;
            }
        }
        else if ("Gladiolus".Equals(flowers))
        {
            if (countFlowers < 80)
            {
                price = (priceFlowersGladiolus * 0.20) + priceFlowersGladiolus;
            }
            else
            {
                price = priceFlowersGladiolus;
            }
        }
        if (budget >= price)
        {
            Console.WriteLine("Hey, you have a great garden with {0} {1} " +
                    "and {2:F2} leva left.", countFlowers, flowers, (budget - price));
        }
        else
        {
            Console.WriteLine("Not enough money, you need {0:F2} leva more.", (price - budget));
        }
    }
}
