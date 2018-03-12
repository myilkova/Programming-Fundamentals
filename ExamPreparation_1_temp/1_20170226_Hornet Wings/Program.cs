using System;

namespace _1_20170226_Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine()); //n wing flaps, a contestant has chosen to do
            double distanceFor1000WFlapsInMeters = double.Parse(Console.ReadLine()); //m distance in meters for 1000 wing flaps
            int enduranceFlapsBeforeRest = int.Parse(Console.ReadLine()); //p how many wing flaps he can make, before he stops to take a break and rest

            int rest = 5; //A hornet rests for 5 seconds
            int wFlapsPerSec = 100; // 100 wing flaps per second

            double metersTraveled = (wingFlaps / 1000.0) * distanceFor1000WFlapsInMeters;
            double secondsPassed = wingFlaps / wFlapsPerSec*1.0;

            if (enduranceFlapsBeforeRest < wingFlaps)
            {
                secondsPassed += (wingFlaps / enduranceFlapsBeforeRest) * rest;
            }

            Console.WriteLine($"{metersTraveled:F2} m."); //FORMATED TO THE SECOND DIGIT AFTER THE DECIMAL POINT
            Console.WriteLine($"{secondsPassed} s."); //THE SECONDS PRINTED WITHOUT FORMATTING

        }
    }
}
