using ArmyManager.Classes;
using ArmyManager.Data;
using ArmyManager.DataController;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using Unit = ArmyManager.Classes.Unit;

namespace ArmyManager
{
    public partial class BuildAUnit : System.Web.UI.Page
    {
        public Controller dc;
        protected void Page_Load(object sender, EventArgs e)
        {
            dc = new Controller();

            dc.Races.Add(new Race("My Race"));
            dc.Traits.Add(new Traits() { Name = "My Trait"});

            foreach (var r in dc.Races)
            {
                ListItem item = new ListItem(r.Name);
                RaceDropdown.Items.Add(item);
            }
            foreach (var r in Enum.GetValues(typeof(SkillLevel.Level)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(SkillLevel.Level), r), r.ToString());
                XPLevelDropdown.Items.Add(item);
            }
            foreach (var r in Enum.GetValues(typeof(UnitTypes.UnitType)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(UnitTypes.UnitType), r), r.ToString());
                UnitTypeDropdown.Items.Add(item);
            }
            foreach (var r in Enum.GetValues(typeof(Equipment.EquipmentLevel)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(Equipment.EquipmentLevel), r), r.ToString());
                EquipmentDropdown.Items.Add(item);
            }
            foreach (var r in Enum.GetValues(typeof(DiceSizes.Dice)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(DiceSizes.Dice), r), r.ToString());
                SizeDropdown.Items.Add(item);
            }
            foreach (var r in dc.Traits)
            {
                ListItem item = new ListItem(r.Name);
                TraitsDropdown.Items.Add(item);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                var name = UnitForm.Name;



                //create canned test data
                var race = new Race(name);
                var unit = new Unit("NameOfUnit", race, SkillLevel.Level.Elite, Equipment.EquipmentLevel.Heavy,
                    UnitTypes.UnitType.Archers, new List<Traits>(), DiceSizes.Dice.d10);


                dc.Units.Add(unit);
                dc.Races.Add(race);
                dc.Races.Add(race);
                dc.Races.Add(race);

                dc.SaveAll();
            }
        }

        private bool ValidInputs()
        {
            if (string.IsNullOrWhiteSpace(UnitForm.Name))
            {
                return false;
            }
            return true;
        }
    }
}