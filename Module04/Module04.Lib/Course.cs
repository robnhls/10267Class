using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.Lib
{
    public class Course
    {

        //Class Members
        //Fields - Variables at the class level
        //      - Manage the State of class

        private string title;
        private int days;

        //Create an automatic Property
        public string Description { get; set; }
        public int Id { get; set; }

        public string Title
        {
            get { return title; }
            set
            {
                //what did the "user" give us?
                //That is stored in a special field named 'value'
                //  only visible in the set of a property

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title cannot be null");
                }

                title = value; //store that in the field
            }
        }

        public int Days
        {
            get
            {
                return days;
            }

            set
            {
                if (value <= 0)
                {
                    //This is lab code
                    //Do not use
                    //Should throw an error instead
                    days = 1;
                }
                else
                {
                    days = value;
                }
            }
        }







        //Constructors


        //Methods
        public string Summarize(string lineEnding = "\n")
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Id: {0}{1}", Id, lineEnding);
            builder.AppendFormat("Title: {0}{1}", Title, lineEnding);
            builder.AppendFormat("Description: {0}{1}", Description, lineEnding);
            builder.AppendFormat("Days: {0}{1}", Days, lineEnding);
            return builder.ToString();
        }


    }//end class
}// end namespace
