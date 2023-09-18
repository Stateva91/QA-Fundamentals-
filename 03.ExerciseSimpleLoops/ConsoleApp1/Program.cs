using System;

internal class Program
{
    private static void Main(string[] args)
    {
        String wantedBook = Console.ReadLine();
        int counter = 0;
        bool isFound = false;
        String input = Console.ReadLine();
        while (!input.Equals("No More Books"))
        {
            if (input.Equals(wantedBook))
            {
                isFound = true;
                break; // namerili sme knigata i izlizame ot cikala
            }
            counter++;
            input = Console.ReadLine();
        }
        if (isFound)
        {
           Console.WriteLine("You checked {0} books and found it.", counter);
        }
        else
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine("You checked {0} books.", counter);
        }
    }
}
