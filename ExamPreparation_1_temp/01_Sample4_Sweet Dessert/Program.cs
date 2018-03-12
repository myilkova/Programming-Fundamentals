using System;

namespace _01_Sample4_Sweet_Dessert
{
    class Program
    {
        const int bananas = 2;
        const int eggs = 4;
        const decimal berries = 0.20m;

        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            int portionSet = 0;
            if (guests % 6 == 0)
            {
                portionSet = guests / 6;
            }
            else
            {
                portionSet = guests / 6 + 1;
            }

            decimal totalPrice = portionSet * (bananas * bananasPrice) + portionSet * (eggs * eggsPrice) + portionSet * (berries * berriesPrice);

            if (totalPrice <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - cash):F2}lv more.");
            }
        }
    }
}
