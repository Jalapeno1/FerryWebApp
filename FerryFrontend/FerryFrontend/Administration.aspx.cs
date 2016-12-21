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
using WebGrease.Css.Extensions;

namespace FerryFrontend
{
    public partial class Administration : System.Web.UI.Page
    {
        private static readonly FerryController Controller = new FerryController();
        public IEnumerable<Ferry> Ferries;
        public IEnumerable<Departure> Departures;

        protected void Page_Load(object sender, EventArgs e)
        {
            InitData();
            
        }

        private void InitData()
        {
            Ferries = Controller.GetAllFerries();
            Departures = Controller.GetAllDepartures();

            foreach (var ferry in Ferries)
                selectedFerry.Items.Add(ferry.Name);
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
            return Ferries;
        }

        public IEnumerable<Departure> GetDepartures()
        {
            return Departures;
        }

        protected void DeleteButton_OnCommand(object sender, CommandEventArgs e)
        {
        }

        protected void CreateDeparture_OnClick(object sender, EventArgs e)
        {
            try
            {
                var da = createDepatureDate.Value.Split('-');
                var ti = da[2].Split('T')[1];
                var hour = Convert.ToInt32(ti.Split(':')[0]);
                var min = Convert.ToInt32(ti.Split(':')[1]);
                var datetime = new DateTime(
                    Convert.ToInt32(da[0]),
                    Convert.ToInt32(da[1]),
                    Convert.ToInt32(da[2].Split('T')[0]), hour, min,0);
                Controller.AddDeparture(Ferries.FirstOrDefault(el => el.Name.Equals(selectedFerry.Value)),
                    datetime);
                //Console.WriteLine(sel);
            }
            catch (Exception exception) { }
            
        }
    }
}