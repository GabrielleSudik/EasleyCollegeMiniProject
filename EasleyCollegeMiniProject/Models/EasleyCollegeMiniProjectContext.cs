using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EasleyCollegeMiniProject.Models
{
    public class EasleyCollegeMiniProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EasleyCollegeMiniProjectContext() : base("name=EasleyCollegeMiniProjectContext")
        {
        }

        public System.Data.Entity.DbSet<EasleyCollegeMiniProject.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<EasleyCollegeMiniProject.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<EasleyCollegeMiniProject.Models.Course_Student_Join> Course_Student_Join { get; set; }
    }
}
