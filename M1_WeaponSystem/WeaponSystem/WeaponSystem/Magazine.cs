using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    public class Magazine
    {
        public string manufacturerName;
        public double ammoCountMod;
        public double reloadSpeedMod;

        public Magazine(string manufacturerName, Manufacturer mod)
        {
            this.manufacturerName = manufacturerName;
            mod.magazineMod.TryGetValue("AmmoCountMod", out ammoCountMod);
            mod.magazineMod.TryGetValue("ReloadSpeedMod", out reloadSpeedMod);
        }
    }
}
