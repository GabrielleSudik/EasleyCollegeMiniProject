﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasleyCollegeMiniProject.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayName("Birthdate")]
        public DateTime DOB { get; set; }
        public string contact { get; set; }
        [DisplayName("Lives on campus?")]
        public bool onCampus { get; set; }
        [DisplayName("Enrollment Date")]
        public DateTime enrollmentDate { get; set; }
    }
}