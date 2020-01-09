using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //SQL Server Data Provider
using Module08.Data;

namespace Module08
{
    public partial class Intro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None; //Where were you set?


        }

        protected void btnConnect_Click(object sender, EventArgs e)
        {
            //ADO has 3 primary classes (interfaces)
            //Connection - Where is DB, How to Authenticate
            //Command    - What to do (select, insert, update, delete)
            //DataReader - Read only data being returned


            // ADO.NET has Data Providers
            //  ** SQL Client (SqlConnection, SqlCommand, SqlDataReader)
            //  Oracle Client
            //  OLEDB

            //string cnstr = "server=(localdb)\\mssqllocaldb; database=northwind; trusted_connection=true";
            //SqlConnection cn = new SqlConnection(cnstr);
            //cn.Open();

            var nw = new Nw();
            var cn = nw.GetConnection();
            cn.Open();

            litMessage.Text = "We Win. Connection is open";
            cn.Close();

        }

        protected void btnShowCategories_Click(object sender, EventArgs e)
        {
            var nw = new Nw();
            var categories = nw.GetCategories();

            //Loop thru the categories and create a list item for each
            foreach (var cat in categories){
                ddlCategoriesManual.Items.Add(new ListItem(cat.Name, cat.CategoryId.ToString()));
            }

            //ddlCategoriesDataBind.DataSource = categories;
            //ddlCategoriesDataBind.DataTextField = "Name";
            //ddlCategoriesDataBind.DataValueField = "CategoryId";
            //ddlCategoriesDataBind.DataBind(); //Everything is ready. Go!

            litMessage.Text = $"Found {categories.Count} categories";


        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var nw = new Nw();
                var category = new Category();
                category.Name = txtName.Text;
                category.Description = txtDescription.Text;

                nw.AddCategory(category);
                litMessage.Text = "Category Added";
            }
            catch (Exception ex)
            {
                litMessage.Text = "Error while adding category";
                System.Diagnostics.Trace.TraceError("Error Adding Category: {0}", ex.ToString());
            }
        }
    }
}