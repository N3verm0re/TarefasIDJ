using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    interface IWeapon
    {
        bool IsADS { get; set; }
        double BaseDamage { get; set; }
        string WeaponName { get; set; }
        double BaseAdsTime { get; set; }
        double BaseRecoil { get; set; }
        double BaseRPM { get; set; }
        int BaseAmmoCount { get; set; }
        double BaseReloadSpeed { get; set; }


        //Gets called while Fire Key is pressed in intervals of time equal to 1/(BaseRPM/60) seconds. If the Weapon is a Shotgun Type, BaseRPM defines how long the Reload action takes instead.
        void Fire();

        //Gets Called either when trying to call Fire() while BaseAmmoCount == 0 or when Reload key is Pressed. Weapons msut get a fullMagazine value from their magazine parts to reset their BaseAmmoCount
        void Reload();

        //Gets called if ADS Key is pressed, changes a bool value from true to false or vice-versa and everytime Fire() is called it checks for that value and applies a hip fire innacuracy stat specific for each weapon type, accordingly. Shotguns CANNOT ADS.
        void ADS();

        //Gets called in weapons constructor to assemble weapon, and everytime a part is swapped out
        void Modify();
    }
}
