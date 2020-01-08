using Module04.Lib;
using Module04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module04
{
    public partial class CourseManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) //This is the first request
            {
                PopulateCourseDropdown();
            }


        }


        protected void ModeChanged(object sender, EventArgs e)
        {
            if (ViewRadioButton.Checked)
            {
                ViewPanel.Visible = true;
                AddPanel.Visible = false;
            }
            else if (AddRadioButton.Checked)
            {
                AddPanel.Visible = true;
                ViewPanel.Visible = false;
            }
            else
            {
                throw new Exception("No display panels have been requested");
            }
        }

        protected void lookupCourseButton_Click(object sender, EventArgs e)
        {
            //Find selected course ID
            var selectedId = int.Parse(CourseSelectionDropDown.SelectedValue);

            //Query "db"
            var db = new CourseDb();
            var course = db.ById(selectedId);


            //Display Summary
            selectedCourseDisplay.Text = course.Summarize("<br/>");
        }



        private void PopulateCourseDropdown()
        {
            var db = new CourseDb();
            var courses = db.All();
            CourseSelectionDropDown.Items.Clear();

            foreach (var c in courses)
            {
                CourseSelectionDropDown.Items.Add(new ListItem(c.Title, c.Id.ToString()));
            }
        }

       
    }
}