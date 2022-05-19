using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Web411031246.ViewModels
{
    
    public class SignUPdata
    {

        [Display(Name ="姓名")]
        [Required(ErrorMessage ="请输入名字")]
        [MinLength(5,ErrorMessage ="请输入5个字")]
        [MaxLength(10, ErrorMessage = "请别超过10个字")]

        public string Name { get; set; }




        [Display(Name = "账号")]
        [Required(ErrorMessage = "请输入账号")]
        [EmailAddress( ErrorMessage = "请输入正确的email")]
        public string Acconut { get; set; }


        [Display(Name = "密码")]
        [Required(ErrorMessage = "请输入密码")]
        [StringLength(10, MinimumLength = 5,ErrorMessage ="请输入5~10个字")]
        public string Password { get; set; }



        /*public string Namemessage { get; set; }
        public string AccountMessage { get; set; }
        public string PasswordMessage { get; set; }
        */

        public string Message { get; set; }



    }
}