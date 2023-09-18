internal class Program
{
    private static void Main(string[] args)
    {
        int goal = 10000;
        int reachedSteps = 0;
        String input = Console.ReadLine();
        while (!input.Equals("Going home"))
        {
            int steps = int.Parse(input);
            reachedSteps += steps;

            if (reachedSteps >= goal)
            {
                break;
            }
            input = Console.ReadLine();
        }
        if (input.Equals("Going home"))
        {
            int stepsToHome = int.Parse(Console.ReadLine());
            reachedSteps += stepsToHome;
        }
        if (reachedSteps >= goal)
        {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine("{0} steps over the goal!", reachedSteps - goal);
        }
        else
        {
            Console.WriteLine("{0} more steps to reach goal.", goal - reachedSteps);
        }
    }
}