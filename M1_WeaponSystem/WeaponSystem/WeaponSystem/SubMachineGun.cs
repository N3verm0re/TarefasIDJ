using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    class SubMachineGun : IWeapon
    {
        Barrel barrel;
        Magazine magazine;
        Stock stock;

        public bool IsADS { get; set; }
        public double BaseDamage { get; set; }
        public double Damage { get => BaseDamage + barrel.damageMod; set => BaseDamage = value; }
        public string WeaponName { get; set; }
        public double BaseAdsTime { get; set; }
        public double AdsTime { get => BaseAdsTime + stock.adsTimeMod; set => BaseAdsTime = value; }
        public double BaseRecoil { get; set; }
        public int BaseAmmoCount { get; set; }
        public int AmmoCount { get => BaseAmmoCount + Convert.ToInt32(magazine.ammoCountMod); set => BaseAmmoCount = value; }
        public double BaseReloadSpeed { get; set; }
        public double ReloadSpeed { get => BaseReloadSpeed + magazine.reloadSpeedMod; set => BaseReloadSpeed = value; }
        public double BaseRPM { get; set; }
        public double RPM { get => BaseRPM + barrel.rpmMod; set => BaseRPM = value; }

        public SubMachineGun(string barrelName, Manufacturer barrelMod, string magazineName, Manufacturer magazineMod, string stockName, Manufacturer stockMod)
        {
            barrel = new Barrel(barrelName, barrelMod);
            magazine = new Magazine(magazineName, magazineMod);
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
