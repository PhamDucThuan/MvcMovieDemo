using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MVCMovie.Models
{
    [Table("Demos")]
    public class Demo
    {
        [Key]
        public string DemoID { get; set; }
        public string DemoName { get; set; }

    }
}