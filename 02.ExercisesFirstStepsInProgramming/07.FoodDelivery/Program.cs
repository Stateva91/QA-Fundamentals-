internal class Program
{
    private static void Main(string[] args)
    {
        int chicken = int.Parse(Console.ReadLine());
        int fish = int.Parse(Console.ReadLine());
        int vegetarian = int.Parse(Console.ReadLine());
        double priceChicken = chicken * 10.35;
        double priceFish = fish * 12.40;
        double priceVegetarian = vegetarian * 8.15;
        double priceMenu = priceFish + priceChicken + priceVegetarian;
        double desert = priceMenu * 20 / 100;
        double sumPrice = priceMenu + desert + 2.50;
        Console.WriteLine(sumPrice);
    }
}