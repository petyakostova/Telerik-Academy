using System;

class ExamSchedule
{
    static void Main()
    {
        int startingHour = int.Parse(Console.ReadLine());
        int startingMinutes = int.Parse(Console.ReadLine());
        string startingTimeOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        int endingHour = startingHour + durationHours;
        int endingMinutes = startingMinutes + durationMinutes;
        string endingTimeOfDay = startingTimeOfDay;

        if (endingMinutes >= 60)
        {
            endingHour++;
            endingMinutes -= 60;
        }

        if (endingHour >= 12 && endingHour < 24)
        {
            if (endingHour != 12)
            {
                endingHour -= 12;
            }
            if (startingTimeOfDay == "AM")
            {
                endingTimeOfDay = "PM";
            }
            else
            {
                endingTimeOfDay = "AM";
            }
        }
        else if (endingHour >= 24)
        {
            endingHour -= 24;
        }

        Console.WriteLine("{0:00}:{1:00}:{2}", endingHour, endingMinutes, endingTimeOfDay);
    }
}