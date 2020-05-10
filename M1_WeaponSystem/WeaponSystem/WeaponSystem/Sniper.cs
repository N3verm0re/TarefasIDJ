using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    public class Sniper : IWeapon
    {
        public bool IsADS { get; set; }
        public double BaseDamage { get; set; }
        public string WeaponName { get; set; }
        public double AdsTime { get; set; }
        public double Recoil { get; set; }
        public int AmmoCount { get; set; }
        public double ReloadSpeed { get; set; }
        public double RPM { get; set; }

        public Sniper()
        {

        }

        public void ADS()
        {
            IsADS = !IsADS;
        }

        public void Fire()
        {
            if (IsADS)
            {
                //Implement Weapon Firing here with using Recoil info and BaseDamage info
            }
            else
            {
                //Implement Weapon Firing here with using Recoil + HipFire Innacuracy Stat info and BaseDamage info
            }
        }

        public void Modify()
        {
            
        }

        public void Reload()
        {
            //Get FullAmmo info from Magazine class
            //AmmoCount = Magazine.FullAmmo
        }
    }
}
