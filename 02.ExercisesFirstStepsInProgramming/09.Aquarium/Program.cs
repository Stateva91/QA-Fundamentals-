internal class Program
{
    private static void Main(string[] args)
    {
        int Length = int.Parse(Console.ReadLine());
        int Width = int.Parse(Console.ReadLine());
        int Height = int.Parse(Console.ReadLine());
        double Percentage = double.Parse(Console.ReadLine());
        double volume = Length * Width * Height;
        double volumeLiter = volume / 1000;
        double space = Percentage / 100;
        double liters = volumeLiter * (1 - space);
        Console.WriteLine(liters);
    }
}