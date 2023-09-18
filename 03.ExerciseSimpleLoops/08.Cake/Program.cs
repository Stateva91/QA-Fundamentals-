internal class Program
{
    private static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        int totalPieces = width * length;

        while (totalPieces >= 0)
        {
            String input = Console.ReadLine(); 
            if (input.Equals("STOP"))
            {
                break;
            }
            int currentPieces = int.Parse(input);
            totalPieces -= currentPieces;
        }
        if (totalPieces > 0)
        {
            Console.WriteLine("{0} pieces are left.", totalPieces);
        }
        else
        {
            Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(totalPieces));
        }
    }
}