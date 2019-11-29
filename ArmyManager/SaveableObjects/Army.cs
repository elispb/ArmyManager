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
        private bool WonLastFight;
        private int Strength;

        public Army()
        {
            Units = new List<Unit>();
        }

        public Army(List<Unit> startingUnits)
        {
            Units = startingUnits;
        }

        public void PassTime(int DaysToPass)
        {

        }
    }
}