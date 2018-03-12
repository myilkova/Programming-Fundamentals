using System;

namespace _1_20170709_Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //n
            int pokeTargetsDistance = int.Parse(Console.ReadLine()); //m
            int exhaustionFactor = int.Parse(Console.ReadLine()); //y

            int targetCounter = 0;
            int currentPower = pokePower;
            double pokePower50Percentage = pokePower / 2.0;

            while (currentPower >= pokeTargetsDistance)
            {
                /*
                 * IF N becomes equal to EXACTLY 50 % of its original value, you must divide N by Y, if it is POSSIBLE. 
                 * This DIVISION is between integers.
                 * 
                 * If a division is not possible, you should NOT do it. Instead, you should continue subtracting.
                 */

                /*
                if ((Math.Abs((double)currentPower - pokePower50Percentage) < Double.Epsilon))
                {
                    if ((currentPower > exhaustionFactor) && (exhaustionFactor != 0))
                    {
                        currentPower = currentPower / exhaustionFactor;
                    }

                    if (currentPower >= pokeTargetsDistance)
                    {
                        currentPower -= pokeTargetsDistance;
                        targetCounter++;
                    }
                }
                else
                {
                    currentPower -= pokeTargetsDistance;
                    targetCounter++;
                }
                */
                currentPower -= pokeTargetsDistance;
                targetCounter++;

                if (currentPower == pokePower / 2 && pokePower % 2 == 0 && exhaustionFactor != 0)
                {
                    currentPower /= exhaustionFactor;
                }

            }
            Console.WriteLine(currentPower);
            Console.WriteLine(targetCounter);            
        }
    }
}
