internal class Program
{
    private static void Main(string[] args)
    {
        String projection = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double income = 0;
        if ("Premiere".Equals(projection))
        {
            income = rows * columns * 12;
        }
        else if ("Normal".Equals(projection))
        {
            income = rows * columns * 7.50;
        }
        else if ("Discount".Equals(projection))
        {
            income = rows * columns * 5;
        }
       Console.WriteLine("{0:F2} leva", income);
    }
}
