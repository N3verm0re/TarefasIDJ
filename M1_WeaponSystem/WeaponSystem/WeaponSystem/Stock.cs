using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    public class Stock
    {
        public string manufacturerName;
        public double hipfireMod;
        public double adsTimeMod;

        public Stock(string manufacturerName, Manufacturer mod)
        {
            this.manufacturerName = manufacturerName;
            mod.stockMod.TryGetValue("HipFireMod", out hipfireMod);
            mod.stockMod.TryGetValue("ADSTimeMod", out adsTimeMod);
        }
    }
}
