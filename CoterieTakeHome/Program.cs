using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CoterieTakeHome
{
    public class Program
    {

        public int hazardClass
        {
            get { return hazardClass; }
            set { hazardClass = 4; }
        }

        public int basePremium
        {
            get { return basePremium; }
            set { basePremium = 6000; }
        }

        public int premiumBeforeFactors
        {
            get { return premiumBeforeFactors; }
            set { premiumBeforeFactors = basePremium * hazardClass; }
        }


        int architectFactor = 1;
        int plumberFactor = 1;
        double programmerFactor = 1.25;


        public int PremiumInOhio()
        {
            int ohRate = 1;
            string userInput = "";
            int ohioFinalResult = 0;

            if (userInput == "Architect")
            {
                ohioFinalResult = ohRate * architectFactor;
            }
            else if (userInput == "Plumber")
            {
                ohioFinalResult = ohRate * plumberFactor;
            }
            else if (userInput == "Programmer")
            {
                ohioFinalResult = (int)(ohRate * programmerFactor);
            }
            else
            {
                return 0;
            }
            return ohioFinalResult * premiumBeforeFactors;
        }



        public int PremiumInFlorida()
        {
            double flRate = 1.2;
            string userInput = "";
            int floridaFinalResult = 0;

            {
                if (userInput == "Architect")
                {
                    floridaFinalResult = (int)(flRate * architectFactor);
                }
                else if (userInput == "Plumber")
                {
                    floridaFinalResult = (int)(flRate * plumberFactor);
                }
                else if (userInput == "Programmer")
                {
                    floridaFinalResult = (int)(flRate * programmerFactor);
                }
                else
                {
                    return 0;
                }
                return floridaFinalResult * premiumBeforeFactors;
            }
        }


        public int PremiumInTexas()
        {
            double txRate = .943;
            string userInput = "";
            int texasFinalResult = 0;

            {
                if (userInput == "Architect")
                {
                    texasFinalResult = (int)(txRate * architectFactor);
                }
                else if (userInput == "Plumber")
                {
                    texasFinalResult = (int)(txRate * plumberFactor);
                }
                else if (userInput == "Programmer")
                {
                    texasFinalResult = (int)(txRate * programmerFactor);
                }
                else
                {
                    return 0;
                }
            }
            return texasFinalResult * premiumBeforeFactors;
        }
    }
}
