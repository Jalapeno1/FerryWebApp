using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using FerryFrontend.Controllers;
using Toolbox3_Library_Hundige;

namespace FerryFrontend
{
    public partial class Administration : System.Web.UI.Page
    {
        private static readonly FerryController Controller = new FerryController();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CreateFerryButton_Click(object sender, EventArgs e)
        {
            createferrymessage.InnerText = "";

            if (ferryname.Value.Trim().Equals(""))
                return;
            if (!IsInteger(peoplecapacity.Value))
                return;
            if (!IsInteger(vehiclecapacity.Value))
                return;
            if (!IsInteger(weightcapacity.Value))
                return;

            var res = Controller.CreateFerry(ferryname.Value, Convert.ToInt32(peoplecapacity.Value),
                Convert.ToInt32(vehiclecapacity.Value), Convert.ToInt32(weightcapacity.Value), isreserve.Checked);

            createferrymessage.InnerText = res ? "Successfully added!" : "Could not create ferry!";
        }

        private bool IsInteger(string input)
        {
            int n;
            return int.TryParse(input, out n);
        }

        public IEnumerable<Ferry> GetFerries()
        {
            return Controller.GetReserveFerries(9999, 9999, 9999999);
        }
    }
}