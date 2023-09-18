internal class Program
{
    private static void Main(string[] args)
    {
        double needMoney =double.Parse(Console.ReadLine());
        double saveMoney = double.Parse(Console.ReadLine());
        int countDays = 0;
        int spendDays = 0;

        while (saveMoney < needMoney)
        {
            if (spendDays == 5)
            {
                break;
            }
            String action = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            countDays++;

            if (action.Equals("save"))
            {
                saveMoney += amount;
                spendDays = 0;
            }
            else
            {
                spendDays++;  //kolko dni e harchila
                saveMoney -= amount;
                if (saveMoney < 0)
                {
                    saveMoney = 0;
                }
            }
        }
        if (spendDays == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(countDays);
        }
        else
        {
            Console.WriteLine($"You saved the money for {countDays} days.");
        }
    }
}
