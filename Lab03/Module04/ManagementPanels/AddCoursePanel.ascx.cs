using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Module04.Lib;
using Module04.Models;

namespace Module04.ManagementPanels
{
    public partial class AddCoursePanel : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text;
            var days = int.Parse(txtDays.Text);
            var desc = txtDescription.Text;

            var c = new Course();

            c.Title = title;
            c.Days = days;
            c.Description = desc;

            var db = new CourseDb();

            db.Add(c);

            //PopulateCourseDropdown();

            //other UI enhancements
            //clear the old values from the textboxes
            //Deliver a success message to the user
            //     or error message
            //Error trap for "db" failure
            //switch to the View panel (?)

        }
    }
}