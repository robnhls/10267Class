using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Module04.Lib;

namespace Module04.Models
{
    public class CourseDb
    {

        private static List<Course> inMemoryCourses = new List<Course> {
            new Course {Id=1, Title="C#", Description="C# course", Days=5},
            new Course {Id=2, Title="Asp.Net", Description="Asp.Net course", Days=5},
            new Course {Id=3, Title="WPF", Description="WPF course", Days=5},
            new Course {Id=4, Title="JavaScript", Description="JavaScript course", Days=5},
            new Course {Id=5, Title="Adv Asp.Net", Description="Adv Asp.Net course", Days=5},
        };


        public IEnumerable<Course> All()
        {
            return inMemoryCourses;
        }

        public Course ById(int id)
        {
            return inMemoryCourses.FirstOrDefault(c => c.Id == id);
        }

        public Course Add(Course newCourse)
        {
            //Horrible autonumbering, leave it to the DB
            int nextId = inMemoryCourses.Count() + 1;
            newCourse.Id = nextId;
            inMemoryCourses.Add(newCourse);

            return newCourse;
        }


    }
}