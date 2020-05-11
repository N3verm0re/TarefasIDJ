using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    class ShotgunMod
    {
        public string manufacturerName;
        public string barrelType;
        public string actionType;

        public ShotgunMod(string manufacturerName, Manufacturer mod)
        {
            this.manufacturerName = manufacturerName;
            mod.shotgunMod.TryGetValue("BarrelType", out barrelType);
            mod.shotgunMod.TryGetValue("Action Type", out actionType);
        }
    }
}
