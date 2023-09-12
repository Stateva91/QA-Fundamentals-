internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfPages = int.Parse(Console.ReadLine());
        int pages = int.Parse(Console.ReadLine());
        int numberOfDates = int.Parse(Console.ReadLine());
        int readingTime = numberOfPages / pages;
        int timeOfDay = readingTime / numberOfDates;
        Console.WriteLine(timeOfDay);
    }
}