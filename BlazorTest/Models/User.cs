using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Models
{
    public class User : LoginModel
    {
        [Display(Name = "使用者名稱")]
        public string Name { get; set; }

        [Display(Name = "使用者權限")]
        public string Role { get; set; }

        [Display(Name = "使用者編號")]
        public int Id { get; set; }

        [Display(Name = "使用者電話號碼")]
        public string Phone { get; set; }
    }

    public class RegisterModel : LoginModel
    {
        [Display(Name = "確認密碼")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "密碼與確認密碼不相符")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "使用者名稱為必填欄位")]
        [Display(Name = "使用者名稱")]
        public string Name { get; set; }

        [Display(Name = "使用者電話號碼")]
        public string Phone { get; set; }
    }
}
