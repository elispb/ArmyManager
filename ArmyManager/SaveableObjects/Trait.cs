using Newtonsoft.Json;
using System.Configuration;
using System.IO;

namespace ArmyManager.SaveableObjects
{
    public class Trait
    {
        public int TraitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }

    }
}