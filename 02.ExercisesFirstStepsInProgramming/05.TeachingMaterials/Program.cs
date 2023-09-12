internal class Program
{
    private static void Main(string[] args)
    {
        int pen = int.Parse(Console.ReadLine());
        int marker = int.Parse(Console.ReadLine());
        int cleans = int.Parse(Console.ReadLine());
        int discount = int.Parse(Console.ReadLine());
        double pricePen = pen * 5.80;
        double priceMarker = marker * 7.20;
        double priceCleans = cleans * 1.20;
        double priceAll = priceCleans + priceMarker + pricePen;
        double priceDiscount = priceAll - (priceAll * discount / 100);
        Console.WriteLine(priceDiscount);
    }
}