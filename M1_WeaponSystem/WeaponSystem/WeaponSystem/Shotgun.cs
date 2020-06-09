using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace WeaponSystem
{
    class Shotgun : GunBehaviour, IWeapon
    {
        Stock stock;
        ShotgunMod shotgunMod;

        public bool IsADS { get; set; }
        public bool IsAutomatic { get; set; }
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

        public void Modify()
        {

        }
    }
}
