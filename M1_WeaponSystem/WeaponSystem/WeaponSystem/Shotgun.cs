using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    class Shotgun : IWeapon
    {
        Stock stock;
        ShotgunMod shotgunMod;

        public bool IsADS { get; set; }
        public double BaseDamage { get; set; }
        public string WeaponName { get; set; }
        public double BaseAdsTime { get; set; }
        public double AdsTime { get => BaseAdsTime + stock.adsTimeMod; set => BaseAdsTime = value; }
        public double BaseRecoil { get; set; }
        public int BaseAmmoCount { get; set; }
        public double BaseReloadSpeed { get; set; }
        public double BaseRPM { get; set; }

        public Shotgun(string stockName, Manufacturer stockMod, string shotgunModName, Manufacturer shotGunModMod)
        {
            stock = new Stock(stockName, stockMod);
            shotgunMod = new ShotgunMod(shotgunModName, shotGunModMod);
        }

        public void ADS()
        {
            IsADS = !IsADS;
        }

        public void Fire()
        {
            if (IsADS)
            {
                //Implement Weapon Firing here with using BaseRecoil info and Damage info
            }
            else
            {
                //Implement Weapon Firing here with using BaseRecoil + HipFire Innacuracy Stat info and Damage info
            }
        }

        public void Modify()
        {

        }

        public void Reload()
        {
            //Get FullAmmo info from BaseAmmoCount (or AmmoCount if magazine mod is present)
            //BaseAmmoCount = Magazine.FullAmmo
            //Shotgun has special reload behaviour, reloading once out of bullets one at a time if single barrel or both at once if double barrel
            //Shotgun has special reload behaviour, triggering different between shot reloads depending on action type
        }
    }
}
