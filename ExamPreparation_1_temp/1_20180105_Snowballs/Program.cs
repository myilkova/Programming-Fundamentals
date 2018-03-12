using System;
using System.Numerics;

namespace _1_20180105_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            PrintHighestSnowballValue(numberOfSnowballs);
        }

        public static void PrintHighestSnowballValue(int numberOfSnowballs)
        {
            int snow = 0;
            int time = 0;
            int quality = 0;

            BigInteger snowballValue = -1;
            //variant 2: string output = "";
            
            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger tempSnowOnTime = (BigInteger)(snowballSnow / snowballTime*1.0);
                BigInteger currentSnowballValue = BigInteger.Pow(tempSnowOnTime, snowballQuality);

                if (currentSnowballValue > snowballValue)
                {
                    snowballValue = currentSnowballValue;

                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;

                    //variant 2: output = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine($"{snow} : {time} = {snowballValue} ({quality})");
            //variant 2: Console.WriteLine(output);

        }
    }
}
