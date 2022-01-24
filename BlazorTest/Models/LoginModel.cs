using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "帳號")]
        public string Account { get; set; }

        [Required]
        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
