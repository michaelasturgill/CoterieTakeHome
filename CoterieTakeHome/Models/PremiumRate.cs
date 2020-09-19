using System;
using System.Reflection.Metadata;

namespace CoterieTakeHome
{
    public class InputFactors
    {
        public int Revenue { get; set; }

        public string State { get; set; }

        public string Profession { get; set; }

    }
    public class PremiumRate
    {
        public decimal TotalPremium { get; set; }
    }
}