using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using WeaponSystem;

namespace ConfigureManufacturer
{
    public static class ManufacturerParser
    {
        public static void SerializeJson(Dictionary<string, Manufacturer> manufacturerList)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            string json = JsonConvert.SerializeObject(manufacturerList, settings);

            File.WriteAllText("Manufacturers.json", json);
        }

        public static void SerializeJson(Dictionary<string, Manufacturer> manufacturerList, string path)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            string json = JsonConvert.SerializeObject(manufacturerList, settings);

            File.WriteAllText(path, json);
        }

        public static Dictionary<string, Manufacturer> DeserializeJson(string path)
        {
            string json = File.ReadAllText(path);
            Dictionary<string, Manufacturer> manufacturerList = JsonConvert.DeserializeObject<Dictionary<string, Manufacturer>>(json);
            return manufacturerList;
        }
    }
}
