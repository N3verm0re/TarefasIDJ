using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    interface IWeapon
    {
        double BaseDamage { get; set; }
        string WeaponName { get; set; }
        double AdsTime { get; set; }
        int AmmoCount { get; set; }
        double ReloadSpeed { get; set; }

        void Fire();
        void Reload();
        void ADS();
        void Modify();
    }
}
