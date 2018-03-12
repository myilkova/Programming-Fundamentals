using System;

namespace _1_20170106_Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            // moje i TimeSpan
            //string[] timeToLeave = Console.ReadLine().Split(':');

            string time = Console.ReadLine();
            string timeFormat = "HH:mm:ss";
            DateTime dt = DateTime.ParseExact(time, timeFormat, null);

            int stepsTaken = int.Parse(Console.ReadLine()) % 86400;
            int timeForStepInSeconds = int.Parse(Console.ReadLine()) % 86400;

         //   int hours = int.Parse(timeToLeave[0]);
         //   int minutes = int.Parse(timeToLeave[1]);
         //   int seconds = int.Parse(timeToLeave[2]);

         //   long
                    
            string result = dt.AddSeconds(stepsTaken* timeForStepInSeconds).ToString("HH:mm:ss");
            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
