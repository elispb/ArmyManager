using ArmyManager.Classes;
using ArmyManager.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace ArmyManager.DataController
{
    public class Controller
    {
        private static string SaveLocation = "C:\\Users\\elisp\\ArmyDataStore\\";

        public List<Race> Races = new List<Race>();
        public List<Traits> Traits = new List<Traits>();
        public List<Unit> Units = new List<Unit>();

        public Controller()
        {
            //Read Races
            //Races = JsonConvert.DeserializeObject<List<Race>>(File.ReadAllText($"{ConfigurationManager.AppSettings["RaceFilePath"]}Races.Json"));
            //Traits = JsonConvert.DeserializeObject<List<Traits>>(File.ReadAllText($"{ConfigurationManager.AppSettings["TraitFilePath"]}Traits.Json"));
            //Units = JsonConvert.DeserializeObject<List<Unit>>(File.ReadAllText($"{ConfigurationManager.AppSettings["UnitFilePath"]}Units.Json"));
        }

        public void SaveAll()
        {
            foreach (var u in Units)
            {
                u.Save();
            }
            using (var file = new StreamWriter($"{ConfigurationManager.AppSettings["TraitFilePath"]}Traits.Json", true))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, this.Traits);
            }
            using (var file = new StreamWriter($"{ConfigurationManager.AppSettings["RaceFilePath"]}Races.Json", true))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, this.Races);
            }
        }
    }
}