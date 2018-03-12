using System;
using System.Collections.Generic;

namespace _1_Sample3_Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            calculateTotalOrderPrice(orders);
        }

        public static void calculateTotalOrderPrice(int orders)
        {

            decimal orderPrice = 0.0m;
            decimal totalPrice = 0.0m;

            List<string> orderPriceList = new List<string>();

            for (int i = 0; i < orders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                string dateFormat = "d/M/yyyy";
                string inputDate = Console.ReadLine();

                decimal capsuleCount = decimal.Parse(Console.ReadLine());
                /*    
                 string[] orderDate = Console.ReadLine().Split('/');
                 int days = DateTime.DaysInMonth(int.Parse(orderDate[2]), int.Parse(orderDate[1]));
                 orderPrice = (days * capsuleCount) * pricePerCapsule;
                 */

                DateTime orderDate = DateTime.ParseExact(inputDate, dateFormat, null);
                orderPrice = (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsuleCount) * pricePerCapsule;

                totalPrice += orderPrice;

                orderPriceList.Add($"The price for the coffee is: ${orderPrice:F2}");
            }

            foreach (var price in orderPriceList)
            {
                Console.WriteLine(price);
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
            //Console.WriteLine($"Total: {totalPrice:C2}");//C is for currency $
           
        }
    }
}       
