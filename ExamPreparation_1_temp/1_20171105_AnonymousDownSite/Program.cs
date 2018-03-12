using System;
using System.Collections.Generic;
using System.Numerics;

namespace _1_20171105_AnonymousDownSite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            List<string> websitesNames = new List<string>();

            decimal siteVisits = 0.0m;
            decimal siteCommercialPricePerVisit = 0.0m;

            decimal totalLoss = 0.0m;
            BigInteger securityToken = 0;

            for (int i = 0; i < numberOfWebsites; i++)
            {
                string[] siteParams = Console.ReadLine().Split(' ');

                websitesNames.Add(siteParams[0]);

                siteVisits = decimal.Parse(siteParams[1]);
                siteCommercialPricePerVisit = decimal.Parse(siteParams[2]);

                totalLoss += siteVisits * siteCommercialPricePerVisit;
            }

            securityToken = BigInteger.Pow(securityKey, numberOfWebsites);

            foreach (var sites in websitesNames)
            {
                Console.WriteLine(sites);
            }
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
