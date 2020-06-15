using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponSystem
{
    public class LightMachineGun : GunBehaviour, IWeapon
    {
        Magazine magazine;
        Stock stock;
        Sights sights;

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

        public LightMachineGun(string magazineName, Manufacturer magazineMod, string stockName, Manufacturer stockMod, string sightsName, Manufacturer sightsMod)
        {
            magazine = new Magazine(magazineName, magazineMod);
            stock = new Stock(stockName, stockMod);
            sights = new Sights(sightsName, sightsMod);
        }

        public void ADS()
        {
            IsADS = !IsADS;
        }

        /*public void Modify()
        {

        }*/
    }
}
