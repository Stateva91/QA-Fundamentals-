internal class Program
{
    private static void Main(string[] args)
    {
        double deposit = double.Parse(Console.ReadLine());
        int term = int.Parse(Console.ReadLine());
        double YearPercentage =double.Parse(Console.ReadLine());
        double Percentage = deposit * YearPercentage / 100;
        double MountPercentage = Percentage / 12;
        double sum = deposit + term * MountPercentage;
        Console.WriteLine(sum);
    }
}