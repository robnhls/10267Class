using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module04
{
    public partial class CodeBehindDemo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = DateTime.Today;
            var message = $"Today is {dt:d}!!!";
            simpleContent.Text = message;

        }

        protected void htmlButton_ServerClick(object sender, EventArgs e)
        {
            var message = "This is a simple server side event";
            placeholder2.InnerText = message;

        }

        protected void serverControlButton_Click(object sender, EventArgs e)
        {
            var message = "This is a web server control server side event";
            placeholder3.Text = message;
        }


    }
}