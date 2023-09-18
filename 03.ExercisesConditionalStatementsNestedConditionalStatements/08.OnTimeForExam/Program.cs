internal class Program
{
    private static void Main(string[] args)
    {
        int hourExam = int.Parse(Console.ReadLine());
        int minExam = int.Parse(Console.ReadLine());
        int hourOfArrival = int.Parse(Console.ReadLine());
        int minOfArrival = int.Parse(Console.ReadLine());

        String late = "Late";
        String onTime = "On time";
        String early = "Early";

        int examAllMin = hourExam * 60 + minExam; //obshto min na nachalniq chas
        int allMinOfArrival = hourOfArrival * 60 + minOfArrival; // obshto vremeto na pristigane
        int totalMinDifference = allMinOfArrival - examAllMin; //кога и в какво време спрямо изпита е пристигнал студентът.

        String studentArrival = late;
        if (totalMinDifference < -30)
        {
            studentArrival = early;
        }
        else if (totalMinDifference <= 0)
        {
            studentArrival = onTime;
        }
        String result = "";
        if (totalMinDifference != 0)
        {
            int hourDifference = Math.Abs(totalMinDifference / 60);
            int minDifference = Math.Abs(totalMinDifference % 60);

            if (hourDifference > 0)
            {
                result = String.Format("%d:%02d hours", hourDifference, minDifference);
            }
            else
            {
                result = minDifference + "minutes";
            }
            if (totalMinDifference < 0)
            {
                result += " before the start";
            }
            else
            {
                result += " after the start";
            }
        }
        Console.WriteLine(studentArrival);

        if (!result.IsEmpty())
        {
           Console.WriteLine(result);

        }
    }
}