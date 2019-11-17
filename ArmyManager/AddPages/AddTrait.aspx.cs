using ArmyManager.DataModel;
using ArmyManager.SaveableObjects;
using System;

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

            ArmyContext.AddTrait(trait);
        }
    }
}