using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    class AssaultRifle : IWeapon
    {
        Barrel barrel;
        Sights sights;
        Stock stock;

        public bool IsADS { get; set; }
        public double BaseDamage { get; set; }
        public double Damage { get => BaseDamage + barrel.damageMod; set => BaseDamage = value; }
        public string WeaponName { get; set; }
        public double BaseAdsTime { get; set; }
        public double AdsTime { get => BaseAdsTime + stock.adsTimeMod; set => BaseAdsTime = value; }
        public double BaseRecoil { get; set; }
        public double Recoil { get => BaseRecoil + sights.recoilMod; set => BaseRecoil = value; }
        public int BaseAmmoCount { get; set; }
        public double BaseReloadSpeed { get; set; }
        public double BaseRPM { get; set; }
        public double RPM { get => BaseRPM + barrel.rpmMod; set => BaseRPM = value; }

        public AssaultRifle(string barrelName, Manufacturer barrelMod, string sightsName, Manufacturer sightsMod, string stockName, Manufacturer stockMod)
        {
            barrel = new Barrel(barrelName, barrelMod);
            sights = new Sights(sightsName, sightsMod);
            stock = new Stock(stockName, stockMod);
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
        }
    }
}
