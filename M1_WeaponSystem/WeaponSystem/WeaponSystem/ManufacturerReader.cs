using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace WeaponSystem
{
    class ManufacturerReader
    {
        public static Dictionary<string, Manufacturer> DeserializeJson(string path)
        {
            string JsonString = File.ReadAllText(path);
            Dictionary<string, Manufacturer> manufacturerList = JsonConvert.DeserializeObject<Dictionary<string, Manufacturer>>(JsonString);
            return manufacturerList;
        }
    }
}
