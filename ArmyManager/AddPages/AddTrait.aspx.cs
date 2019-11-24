using ArmyManager.DataModel;
using ArmyManager.SaveableObjects;
using System;
using System.Collections.Generic;

namespace ArmyManager.AddPages
{
    public partial class AddTrait : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            var trait = new Trait() {
                Name = TraitName.Value,
                Description = TraitDesc.Value,
                Cost = int.Parse(TraitCost.Value)
            };

            var listOfRaces = new List<Race>();
            for (int i = 0; i < RaceCheckBoxList.Items.Count; i++)
            {
                var race = ArmyContext.GetRaceById(int.Parse(RaceCheckBoxList.Items[i].Value));
                race.RaceTraits.Add(trait);
                ArmyContext.UpdateRace(race);
            }

            ArmyContext.AddTrait(trait);
        }
    }
}