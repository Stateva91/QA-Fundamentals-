internal class Program
{
    private static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int volume = width * length * height;

        while (volume > 0)
        {

            String input = Console.ReadLine();
            if (input.Equals("Done"))
            {
                break;
            }
            int boxVolume = int.Parse(input);
            volume -= boxVolume;
        }
        if (volume > 0)
        {
            Console.WriteLine("{0} Cubic meters left.", volume);
        }
        else
        {
            Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(volume));
        }


    }
}