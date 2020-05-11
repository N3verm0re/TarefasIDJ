using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    public class Sniper : IWeapon
    {
        SniperSights sights;
        Stock stock;
        Magazine magazine;

        public bool IsADS { get; set; }
        public double BaseDamage { get; set; }
        public string WeaponName { get; set; }
        public double BaseAdsTime { get; set; }
        public double AdsTime { get => BaseAdsTime + stock.adsTimeMod; set => BaseAdsTime = value; }
        public double BaseRecoil { get; set; }
        public double Recoil { get => BaseRecoil + sights.recoilMod; set => BaseRecoil = value; }
        public int BaseAmmoCount { get; set; }
        public int AmmoCount { get => BaseAmmoCount + Convert.ToInt32(magazine.ammoCountMod); set => BaseAmmoCount = value; }
        public double BaseReloadSpeed { get; set; }
        public double ReloadSpeed { get => BaseReloadSpeed + magazine.reloadSpeedMod; set => BaseReloadSpeed = value; }
        public double BaseRPM { get; set; }

        public Sniper(string sightsName, Manufacturer sightsMod, string stockName, Manufacturer stockMod, string magazineName, Manufacturer magazineMod)
        {
            sights = new SniperSights(sightsName, sightsMod);
            stock = new Stock(stockName, stockMod);
            magazine = new Magazine(magazineName, magazineMod);
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
