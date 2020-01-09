using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Module08.Data
{
    public class Nw
    {
        //Constructor - Initialize and Object
        public Nw()
        {

            connectionString = WebConfigurationManager.ConnectionStrings["nw"].ConnectionString;

        }

        private readonly string connectionString;


        /// <summary>
        /// Gets a closed connection for the SQL Database
        /// </summary>
        /// <returns>Closed Connection</returns>
        public SqlConnection GetConnection()
        {
            var cn = new SqlConnection(connectionString);
            return cn;
        }

        public List<Category> GetCategories()
        {
            //Establish Connection
            using (SqlConnection cn = GetConnection())
            {
                //Create a command to get all categories
                SqlCommand cmd = cn.CreateCommand();
                //var cmd = new SqlCommand();
                //cmd.Connection = cn;

                cmd.CommandText = "SELECT CategoryId, CategoryName, Description FROM Categories ORDER BY CategoryName";
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Open();
                //cmd.ExecuteNonQuery(); //Insert, Update, Delete, Grant, Deny, Alter, Drop, Create => # rows affected
                //cmd.ExecuteScalar();   //SELECT COUNT(*) FROM Categories => First Row/First Column
                //cmd.ExecuteReader();   //SELECT * FROM Categories => DataReader object

                //Copy data into Category Objects
                List<Category> categories = new List<Category>();

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    //Loop thru the reader and create a category object for each row
                    while (reader.Read()) //Advance the cursor and return true if we find a row, false when done
                    {
                        var category = new Category();
                        category.CategoryId = (int)reader[0];           //Ordinal Position
                        category.Name = (string)reader["CategoryName"]; //Name of column as aliased in SQL
                        category.Description = reader.GetString(2);     //Data Type specific lookup by ordinal

                        //Add to the collection
                        categories.Add(category);
                    }
                } //Auto close reader

                return categories;
            } //Auto close/dispose the connection object
        } //end GetCategories


        public void AddCategory(Category newCategory)
        {
            //name = "Rob's Sugar Tonic";   
            //description = "This is powerfull stuff'); drop table Categories -- SQL Injection Attack

            using (SqlConnection cn = GetConnection())
            {
                var sql = $"INSERT INTO Categories (CategoryName, Description) " +
                          $" VALUES (@name, @description)";

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@name", newCategory.Name);
                cmd.Parameters.AddWithValue("@description", newCategory.Description);

                cn.Open();

                var rowCount = cmd.ExecuteNonQuery();
                if (rowCount != 1)
                {
                    System.Diagnostics.Trace.TraceWarning("Failed to insert category with values of {0} and {1}",
                        newCategory.Name, newCategory.Description);

                    throw new InvalidOperationException("Insert category Failed");
                }

                
            }

        }

    } //end Nw
}//end namespace