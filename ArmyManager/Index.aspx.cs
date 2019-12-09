using ArmyManager.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArmyManager
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (var unit in ArmyContext.GetUnits())
            {
                unitDisplay.Controls.Add(new LiteralControl(DisplayHelper.UnitToHtml(unit)));
            }
        }
    }
}