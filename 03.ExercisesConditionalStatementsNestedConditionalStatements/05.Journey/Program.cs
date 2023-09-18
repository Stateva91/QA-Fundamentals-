internal class Program
{
    private static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        String season = Console.ReadLine();
        double price = 0;
        String destination = "";
        String place = "";
        if (budget <= 100)
        {
            if ("summer".Equals(season))
            {
                price = budget * 0.30;
                destination = "Bulgaria";
                place = "Camp";
            }
            else if ("winter".Equals(season))
            {

                price = budget * 0.70;
                destination = "Bulgaria";
                place = "Hotel";

            }
        }
        else if (budget <= 1000)
        {
            if ("summer".Equals(season))
            {
                price = budget * 0.40;
                destination = "Balkans";
                place = "Camp";
            }
            else if ("winter".Equals(season))
            {

                price = budget * 0.80;
                destination = "Balkans";
                place = "Hotel";
            }
        }
        else if (budget > 1000)
        {
            if ("summer".Equals(season) || "winter".Equals(season))
            {
                price = budget * 0.90;
                destination = "Europe";
                place = "Hotel";
            }
        }
        Console.WriteLine("Somewhere in {0}\n", destination);
        Console.WriteLine("{0} - {1:F2}", place, price);
    }
}
