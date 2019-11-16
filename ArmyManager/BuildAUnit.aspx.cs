using ArmyManager.Classes;
using ArmyManager.Data;
using ArmyManager.DataController;
using System;
using System.Collections.Generic;

namespace ArmyManager
{
    public partial class BuildAUnit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create canned test data
            var race = new Race("Dwarf");
            var unit = new Unit("NameOfUnit", race, SkillLevel.Level.Elite, Equipment.EquipmentLevel.Heavy,
                UnitTypes.UnitType.Archers, new List<Traits>(), DiceSizes.Dice.d10);
            unit.Save();
        }
    }
}