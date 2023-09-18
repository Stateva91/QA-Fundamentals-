internal class Program
{

    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
        int sumWithOutMaxNumber = sum - max;
        if (max == sumWithOutMaxNumber)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {max}");
        }
        else
        {
            int diff = Math.Abs(max - sumWithOutMaxNumber);
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {diff}");
        }
    }
}
