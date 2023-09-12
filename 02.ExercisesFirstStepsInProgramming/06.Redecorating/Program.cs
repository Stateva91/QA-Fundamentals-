internal class Program
{
    private static void Main(string[] args)
    {
        int amountOfNylon = int.Parse(Console.ReadLine());
        int amountOfFight = int.Parse(Console.ReadLine());
        int thinner = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        double sumNylon = (amountOfNylon + 2) * 1.50;
        double sumFight = (amountOfFight + amountOfFight * 0.10) * 14.50;
        double sumThinner = thinner * 5.00;
        double sumBags = 0.40;
        double sumMaterial = sumBags + sumFight + sumThinner + sumNylon;
        double sumMaster = (sumMaterial * 0.30) * hours;
        double sum = sumMaterial + sumMaster;
       Console.WriteLine(sum);
    }
}