using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    public class SniperSights
    {
        public double recoilMod;
        public double zoomValue;
        public string manufacturerName;
        public SniperSights (string manufacturerName, Manufacturer mod)
        {
            mod.sniperSightsMod.TryGetValue("RecoilMod", out recoilMod);
            mod.sniperSightsMod.TryGetValue("ZoomMod", out zoomValue);
            this.manufacturerName = manufacturerName;
        }
    }
}
