using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace WeaponSystem
{
    public class Sniper : GunBehaviour, IWeapon
    {
        SniperSights sights;
        Stock stock;
        Magazine magazine;

        public bool IsADS { get; set; }
        public bool IsAutomatic { get; set; }
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

        public void Modify()
        {
            
        }
    }
}
