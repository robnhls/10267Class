using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module01
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                secondParagraph.InnerText = "Page rendered at " + DateTime.Now;
                //Read the value of the stateDropdown and render a message
                //abv is in the value property
                //name is in the Text Property

                string abv = stateDropdown.SelectedValue;
                string name = stateDropdown.SelectedItem.Text;

                string message = $"you have selected {abv} {name}";
                firstParagraph.InnerText = message;



                string firstName = "rob";
                string lastName = "foulkrod";
                string title = "Instructor";
                DateTime hireDate = DateTime.Parse("06/30/1997");
                decimal salary = 22000;

                string summary = $"{firstName} {lastName} was {hireDate:d} on date as a(n) {title}" +
                    $" with a salary of {salary:c}";

            }

        }


    }
}