﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EF_CF.EF
{
    public class UMSContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course>Courses { get; set; }
        //public DbSet<Course> Courses { get; set; }

        public UMSContext() : base("name=studentDB") { 
        
        }
    }
}
