using Newtonsoft.Json;
using System.Configuration;
using System.IO;

namespace ArmyManager.Data
{
    public class Traits
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Cost { get; private set; }

        public void Save()
        {
            using (StreamWriter file = File.CreateText($"{ConfigurationManager.AppSettings["TrsitFilePath"]}{Name}"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, this);
            }
        }
    }
}