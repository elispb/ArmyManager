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
        
    }
}