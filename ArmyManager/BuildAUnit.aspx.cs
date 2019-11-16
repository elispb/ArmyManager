using ArmyManager.Classes;
using ArmyManager.Data;
using ArmyManager.DataController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using static ArmyManager.Data.DiceSizes;
using static ArmyManager.Data.Equipment;
using static ArmyManager.Data.SkillLevel;
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
            dc.Traits.Add(new Traits() { Name = "My Trait" });


            //Populate dropdowns
            foreach (var r in dc.Races)
            {
                ListItem item = new ListItem(r.Name);
                RaceDropdown.Items.Add(item);
            }
            foreach (var r in Enum.GetValues(typeof(Level)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(Level), r), r.ToString());
                XPLevelDropdown.Items.Add(item);
            }
            foreach (var r in Enum.GetValues(typeof(UnitTypes.UnitType)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(UnitTypes.UnitType), r), r.ToString());
                UnitTypeDropdown.Items.Add(item);
            }
            foreach (var r in Enum.GetValues(typeof(EquipmentLevel)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(EquipmentLevel), r), r.ToString());
                EquipmentDropdown.Items.Add(item);
            }
            foreach (var r in Enum.GetValues(typeof(Dice)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(Dice), r), r.ToString());
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
                var name = UnitName.Value;
                var race = dc.Races.Select(x => x).Where(r => r.Name == RaceDropdown.SelectedValue).FirstOrDefault();
                Enum.TryParse(XPLevelDropdown.SelectedValue, out Level level);
                Enum.TryParse(EquipmentDropdown.SelectedValue, out EquipmentLevel equipment);
                Enum.TryParse(UnitTypeDropdown.SelectedValue, out UnitTypes.UnitType unitType);
                Enum.TryParse(SizeDropdown.SelectedValue, out Dice size);


                //create canned test data
                var unit = new Unit(name, race, level, equipment,
                    unitType, new List<Traits>(), size);


                dc.Units.Add(unit);
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