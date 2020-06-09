using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace WeaponSystem
{
    class AssaultRifle : GunBehaviour, IWeapon
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
        public bool IsAutomatic { get; set; }

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

        public void Modify()
        {

        }
    }
}
