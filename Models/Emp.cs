using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpProj.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required.!")]
         public int EmpID { get; set; }

        [Required(ErrorMessage = "Required.!")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Required.!")]

        public string Dept { get; set; }

        [Required(ErrorMessage = "Required.!")]
        public string Sex { get; set; }

        [Required(ErrorMessage = "Required.!")]
        public string Marital_status { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "Address should be minimum of 10 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Required.!")]
        public string Salary { get; set; }

        [Required(ErrorMessage = "Required.!")]
        public string PhoneNum { get; set; }

    }
}