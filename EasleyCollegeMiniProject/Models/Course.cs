using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasleyCollegeMiniProject.Models
{
    public class Course
    {
        [Key] //this stuff in the brackets are DataAnnotations
        //it's telling VS how we want to handle all of this info
        public int ID { get; set; }

        //the [whatever] goes directly above whatever it affects
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name ="Credit Hours", Description = "Course Hours")]
        public int CreditHours { get; set; }
        public string Location { get; set; }
        public int Section { get; set; }

        //fyi: right-click a property; it will give a Show All References choice
        //to find other places it exists in the code, if you want to change or whatever

        //you don't have one here, but i THINK ICollection and "Course Course" (etc)
        //are the same thing
    }
}