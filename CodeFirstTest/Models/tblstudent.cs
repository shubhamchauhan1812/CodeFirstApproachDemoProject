using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstTest.Models
{
    public class tblstudent
    {
        [Key]
        public int sid { get; set; }
        public string name { get; set; }
        public int country { get; set; }
        public int state { get; set; }
    }
}