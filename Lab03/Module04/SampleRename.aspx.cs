using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module04
{
    public partial class SampleRename : System.Web.UI.Page
    {




        protected void Page_Load(object sender, EventArgs e)
        {
            var dt = DateTime.Today;
            var message = $"Today is {dt:d}!!!";
            simpleContent.Text = message;

        }
    }
}