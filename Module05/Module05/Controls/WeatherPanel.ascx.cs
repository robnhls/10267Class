using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module05.Controls
{
    public partial class WeatherPanel : System.Web.UI.UserControl
    {

        public string City { get; set; }



        string[] weatherOptions = {
            "Partly Sunny",
            "Mostly Cloudy",
            "Scattered Showers",
            "Snow Storm",
            "Clear and Sunny"
        };


        private static Random rnd = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            cityNameLiteral.Text = City;

            //lookup information for the particular city

            dateLiteral.Text = DateTime.Today.ToLongDateString();
            var rndIndex = rnd.Next(weatherOptions.Length);
            var report = weatherOptions[rndIndex];

            forcast.Text = report;
        }
    }
}