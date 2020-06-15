using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    interface IWeapon
    {
        bool IsADS { get; set; }
        bool IsAutomatic { get; set; }
        double BaseDamage { get; set; }
        string WeaponName { get; set; }
        double BaseAdsTime { get; set; }
        double BaseRecoil { get; set; }
        double BaseRPM { get; set; }
        int BaseAmmoCount { get; set; }
        double BaseReloadSpeed { get; set; }

        //Gets called if ADS Key is pressed, changes a bool value from true to false or vice-versa and everytime Fire() is called it checks for that value and applies a hip fire innacuracy stat specific for each weapon type, accordingly. Shotguns CANNOT ADS.
        void ADS();

        //Gets called in weapons constructor to assemble weapon, and everytime a part is swapped out
        //void Modify();
    }
}
