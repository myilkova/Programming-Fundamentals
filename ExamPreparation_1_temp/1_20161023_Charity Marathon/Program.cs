using System;
using System.Numerics;

namespace _1_20161023_Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int avgLaps = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKM = double.Parse(Console.ReadLine());

            int maxRunners = 0;

            if (runners > (capacity * days))
            {
                maxRunners = capacity * days;
            }
            else
            {
                maxRunners = runners;
            }

            long totalMeters = (long)maxRunners * avgLaps * length;
            long totalKM = totalMeters/ 1000;
            double moneyRaised = totalKM * moneyPerKM;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
