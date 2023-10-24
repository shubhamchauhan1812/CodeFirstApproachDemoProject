using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstTest.Models
{
    public class tblstate
    {
        [Key]
        public int stid { get; set; }
        public int cid { get; set; }
        public string sname { get; set; }

    }
}