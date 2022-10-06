using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmpProj.Models
{
    public class Sal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required.!")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Required.!")]
        public int EmpID { get; set;}
        [ForeignKey("EmpID")]
        public Emp Emp { get; set; }

        
    }
}