using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Tuple<int, int, int, BigInteger>> listOfValues = new List<Tuple<int, int, int, BigInteger>>();

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger tempSnowOnTime = (BigInteger)(snowballSnow / snowballTime * 1.0);
                BigInteger snowballValue = BigInteger.Pow(tempSnowOnTime, snowballQuality);

                var tuple4Parts = new Tuple<int, int, int, BigInteger>
                    (snowballSnow, snowballTime, snowballQuality, snowballValue);

                listOfValues.Add(tuple4Parts);
            }
            var highestSnowballValue = listOfValues.OrderByDescending(x => x.Item4).First();
            Console.WriteLine($"{highestSnowballValue.Item1} : {highestSnowballValue.Item2} = {highestSnowballValue.Item4} ({highestSnowballValue.Item3})");
        }
    }
}
