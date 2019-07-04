using System;
using System.Collections.Generic;

namespace WebsiteAvailabilityTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            SiteListChanger.ConfigureXml();
            List<Site> sites = SiteListChanger.LoadSites();

            UserInterface.PrintCommandList();
            bool endWork = false;
            while (!endWork)
            {
                UserInterface.ReadCommand(ref sites, ref endWork);
            }
        }
    }
}
