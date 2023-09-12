internal class Program
{
    private static void Main(string[] args)
    {
        int training = int.Parse(Console.ReadLine());
        double priceSneakers = training - (training * 40 / 100);
        double priceOutfit = priceSneakers - (priceSneakers * 20 / 100);
        double priceBall = priceOutfit / 4;
        double priceAccessories = priceBall / 5;
        double sumPrice = training + priceAccessories + priceOutfit + priceSneakers + priceBall;
       Console.WriteLine(sumPrice);
    }
}