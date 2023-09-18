internal class Program
{
    private static void Main(string[] args)
    {
        String month = Console.ReadLine();
        int nightsCnt = int.Parse(Console.ReadLine());
        double studioPrice = 0.0;
        double apartmentPrice = 0.0;

        switch (month)
        {
            case "May":
            case "October":
                studioPrice = 50;
                apartmentPrice = 65;
                if (nightsCnt > 7 && nightsCnt <= 14)
                {
                    studioPrice = studioPrice * 0.95;
                }
                else if (nightsCnt > 14)
                {
                    studioPrice = studioPrice * 0.7;
                }
                if (nightsCnt > 14)
                {
                    apartmentPrice = apartmentPrice * 0.9;
                }
                break;
            case "June":
            case "September":
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (nightsCnt > 14)
                {
                    studioPrice = studioPrice * 0.8;
                    apartmentPrice = apartmentPrice * 0.9;
                }
                break;
            case "July":
            case "August":
                apartmentPrice = 77;
                studioPrice = 76;
                if (nightsCnt > 14)
                {
                    apartmentPrice = apartmentPrice * 0.9;
                }
                break;
        }
        Console.WriteLine("Apartment: {0:F2} lv.\n", apartmentPrice * nightsCnt);
        Console.WriteLine("Studio: {0:F2} lv.", studioPrice * nightsCnt);
    }
}