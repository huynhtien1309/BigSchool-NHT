using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_NHT.Models.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public String Place { get; set; }
        [Required]
        public String Date { get; set; }
        [Required]
        public String Time { get; set; }
        [Required]
        public byte Category { get; set; }
        [Required]
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date,Time));
        }

    }
}