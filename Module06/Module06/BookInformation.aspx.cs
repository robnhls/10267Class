using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module06
{
    public partial class BookInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Validation goes here

            //if valid clear form and message user
            if (Page.IsValid)
            {

                ClearForm();
                litMessage.Text = "Book has been added";
            }
        }

        private void ClearForm()
        {
            txtAuthor.Text = "";
            txtEmail.Text = "";
            txtPageCount.Text = "";
            txtTitle.Text = "";
            ddlCategory.SelectedIndex = 0; //select the first item on the list

        }

        protected void custVPageCount_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var pages = int.Parse(args.Value);
            if(pages % 2 == 0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}