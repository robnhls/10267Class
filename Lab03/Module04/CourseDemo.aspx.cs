using Module04.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module04
{
    public partial class CourseDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void demoButton_Click(object sender, EventArgs e)
        {

            var c = new Course();
            c.Id = 131;
            c.Title = "How to make a million";
            c.Days = 5;
            c.Description = "Make a million dollars on the backs of your friends";

            var summary = c.Summarize("<br/>");
            samplePlaceholder.Text = summary;

        }
    }
}