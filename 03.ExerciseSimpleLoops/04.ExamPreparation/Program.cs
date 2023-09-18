using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int countPoorGrades = int.Parse(Console.ReadLine());
        int count = 0;
        int totalSumGrade = 0;
        double countProblems = 0;
        String lastProblems = "";
       bool win = false;
        while (count < countPoorGrades)
        {

            String problemName = Console.ReadLine();
            if (problemName.Equals("Enough"))
            {
                win = true;
                break;
            }

            int currentGrade = int.Parse(Console.ReadLine());
            if (currentGrade <= 4)
            {
                count++;
            }
            countProblems++;
            totalSumGrade += currentGrade;
            lastProblems = problemName;

        }
        if (win)
        {
          Console.WriteLine("Average score: {0:F2}\n", totalSumGrade / countProblems);
           // Console.WriteLine("Number of problems: {0}\n", countProblems);
           // Console.WriteLine("Last problem: {0}", lastProblems);
        }
        else
        {
            Console.WriteLine("You need a break, {0} poor grades.", count);
        }
    }
}
