using ArmyManager.Classes;
using ArmyManager.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ArmyManager.DataController
{
    public class DataControls
    {
        private string SaveLocation = "C:\\Users\\elisp\\source\\repos\\ArmyManager\\ArmyManager\\App_Data\\";

        public List<Race> Races;
        public List<Traits> Traits;
        public List<Unit> Units;

        public DataControls()
        {
            //Read Races
            Races = JsonConvert.DeserializeObject<List<Race>>(File.ReadAllText($"{SaveLocation}Races.Json"));
            Traits = JsonConvert.DeserializeObject<List<Traits>>(File.ReadAllText($"{SaveLocation}Traits.Json"));
            Units = JsonConvert.DeserializeObject<List<Unit>>(File.ReadAllText($"{SaveLocation}Units.Json"));
        }

        public void SaveAll()
        {
            using (StreamWriter file = File.CreateText($"{SaveLocation}Units.Json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, Units);
            }
        }
    }
}