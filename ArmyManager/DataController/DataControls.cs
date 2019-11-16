using ArmyManager.Classes;
using ArmyManager.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ArmyManager.DataController
{
    public class DataControls
    {
        private static string SaveLocation = "C:\\Users\\elisp\\ArmyDataStore\\";

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

        public static void Save(Unit unitToSave)
        {
            using (StreamWriter file = File.CreateText($"{SaveLocation}Units.Json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, unitToSave);
            }
        }
    }
}