using System;
using System.Collections.Generic;

using ArmyManager.DataModel;
using ArmyManager.SaveableObjects;

namespace ArmyManager.AddPages
{
    public partial class AddRace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateRace_Click(object sender, EventArgs e)
        {
            var selectedTraits = new List<Trait>();
            for (int i = 0; i < TraitCheckboxList.Items.Count; i++)
            {
                if (TraitCheckboxList.Items[i].Selected)
                {
                    selectedTraits.Add(ArmyContext.GetTraitById(int.Parse(TraitCheckboxList.Items[i].Value)));
                }
            }

            var race = new Race()
            {
                Name = RaceName.Value,
                Attack = int.Parse(Attack.Value),
                Defence = int.Parse(Defense.Value),
                Power = int.Parse(Power.Value),
                Toughness = int.Parse(Toughness.Value),
                Morale = int.Parse(Morale.Value),
                RaceTraits = selectedTraits
            };

            ArmyContext.AddRace(race);
        }
    }
}