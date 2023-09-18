internal class Program
{
    private static void Main(string[] args)
    {
        int degrees = int.Parse(Console.ReadLine());
        String dayTime = Console.ReadLine();
        String outfit = "";
        String shoes = "";
        if ("Morning".Equals(dayTime))
        {
            if (degrees >= 10 && degrees <= 18)
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (degrees > 18 && degrees <= 24)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
        }
        if ("Afternoon".Equals(dayTime))
        {
            if (degrees >= 10 && degrees <= 18)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (degrees > 18 && degrees <= 24)
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";

            }
        }
        if ("Evening".Equals(dayTime))
        {
            if (degrees >= 10 && degrees <= 18)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (degrees > 18 && degrees <= 24)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        }
        Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, outfit, shoes);
    }
}
