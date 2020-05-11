using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    class Sights
    {
        public double recoilMod;
        public double zoomValue;
        public string manufacturerName;
        public Sights(string manufacturerName, Manufacturer mod)
        {
            mod.sightsMod.TryGetValue("RecoilMod", out recoilMod);
            mod.sightsMod.TryGetValue("ZoomMod", out zoomValue);
            this.manufacturerName = manufacturerName;
        }
    }
}
