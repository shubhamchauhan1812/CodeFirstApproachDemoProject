using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CodeFirstTest.Models
{
    public class DBContextClass :DbContext
    {
        public DBContextClass() : base("ADB")
        {

        }
        public DbSet<tblstudent> tblstudents { get; set; }
        public DbSet<tblcountry> tblcountries { get; set; }
        public DbSet<tblstate> tblstates { get; set; }
    }
}