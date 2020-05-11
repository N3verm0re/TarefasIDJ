using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    class Barrel
    {
        public string manufacturerName;
        public double damageMod;
        public double rpmMod;

        public Barrel(string manufacturerName, Manufacturer mod)
        {
            this.manufacturerName = manufacturerName;
            mod.barrelMod.TryGetValue("DamageMod", out damageMod);
            mod.barrelMod.TryGetValue("RPMMod", out rpmMod);
        }
    }
}
