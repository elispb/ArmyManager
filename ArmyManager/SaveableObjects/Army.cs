using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArmyManager.SaveableObjects
{
    public class Army
    {
        public List<Unit> Units;
        public Faction Owner;

        private List<Faction> FactionsDefeated;
        private List<Faction> FactionsLostTo;
        private bool? WonLastFight;
        private int Strength;

        public Army(Faction faction)
        {
            Units = new List<Unit>();
            Owner = faction;
        }

        public Army(Faction faction, List<Unit> startingUnits)
        {
            Units = startingUnits;
            Owner = faction;

            foreach (var unit in Units)
            {
                Strength += unit.Cost;
            }
        }

        public void PassTime(int DaysToPass)
        {
            foreach(var unit in Units)
            {
                unit.RecoverOverTime(DaysToPass);
            }
        }
    }
}