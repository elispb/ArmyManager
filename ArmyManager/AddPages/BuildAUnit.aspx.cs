using ArmyManager.SaveableObjects;
using ArmyManager.Data;
using ArmyManager.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using static ArmyManager.Data.DiceSizes;
using static ArmyManager.Data.Equipment;
using static ArmyManager.Data.SkillLevel;

namespace ArmyManager
{
    public partial class BuildAUnit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Populate dropdowns
            foreach (var xpLevel in Enum.GetValues(typeof(Level)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(Level), xpLevel), xpLevel.ToString());
                XPLevelDropdown.Items.Add(item);
            }
            foreach (var unitType in Enum.GetValues(typeof(UnitTypes.UnitType)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(UnitTypes.UnitType), unitType), unitType.ToString());
                UnitTypeDropdown.Items.Add(item);
            }
            foreach (var equipmentType in Enum.GetValues(typeof(EquipmentLevel)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(EquipmentLevel), equipmentType), equipmentType.ToString());
                EquipmentDropdown.Items.Add(item);
            }
            foreach (var size in Enum.GetValues(typeof(Dice)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(Dice), size), size.ToString());
                SizeDropdown.Items.Add(item);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                var name = UnitName.Value;
                var race = ArmyContext.GetRaceById(int.Parse(RaceDropdown.SelectedValue));
                Enum.TryParse(XPLevelDropdown.SelectedValue, out Level level);
                Enum.TryParse(EquipmentDropdown.SelectedValue, out EquipmentLevel equipment);
                Enum.TryParse(UnitTypeDropdown.SelectedValue, out UnitTypes.UnitType unitType);
                Enum.TryParse(SizeDropdown.SelectedValue, out Dice size);
                List<Trait> unitTratits = new List<Trait>();

                foreach (var sItem in TraitsList.Items.Cast<ListItem>().Where(sItem => sItem.Selected))
                {
                    var toAdd = ArmyContext.GetTraitById(int.Parse(sItem.Value));
                    unitTratits.Add(toAdd);
                }

                //Create unit from inputs
                var unit = new SaveableObjects.Unit(name, race, level, equipment,
                    unitType, unitTratits, size);

                //Add Unit and Race to DataLists
                ArmyContext.AddUnit(unit);
            }
        }

        private bool ValidInputs()
        {
            if (string.IsNullOrWhiteSpace(UnitName.Value))
            {
                return false;
            }
            return true;
        }
    }
}