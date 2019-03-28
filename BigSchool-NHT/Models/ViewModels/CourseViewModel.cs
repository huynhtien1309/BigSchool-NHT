using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool_NHT.Models.ViewModels
{
    public class CourseViewModel
    {
        public String Place { get; set; }
        public String Date { get; set; }
        public String Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date,Time));
        }

    }
}