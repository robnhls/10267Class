using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Diagnostics;

namespace Module07
{
    public partial class Troubleshooting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInvoke_Click(object sender, EventArgs e)
        {
            try
            {
                //Breakpoints only work when the debugger is attached
                //1) The project is compiled in a debug build - See Web.config
                //2) Debug the project (f5) not [ctrl + f5]
                var result = Calculate();

                litMessage.Text = $"Your answer is {result}";
            }
            catch (OverflowException)
            {
                litMessage.Text = $"Please enter values between {int.MinValue} and {int.MaxValue}.";
            }
            catch (FormatException)
            {
                litMessage.Text = "Please enter a whole number.";
            }
            //catch (DivideByZeroException)
            //{
            //    litMessage.Text = "Your answer is 0";
            //}
            catch(Exception ex)
            {

                Trace.Warn("User Processing", "Error while calculating", ex);
                litMessage.Text = "There was an error processing your request";
                //litMessage.Text = ex.Message; //this is generally bad
            }
            finally
            {
                //This code will run EVERY time
                //If there is an Exception, it runs
                //if there is NO exception, it runs
                //Often for clean up

            }

        }

        private int Calculate()
        {
            Trace.Write("Calling the calculate function");
            var number = int.Parse(txtNumber.Text);
            //Debug.Assert(number != 0);

            Trace.Write("Accepted the user input");
            var baseNumber = 100;
            var result = baseNumber / number;
            Trace.Write("Completed Calculation. Answer was " + result);
            return result;
        }
    }
}