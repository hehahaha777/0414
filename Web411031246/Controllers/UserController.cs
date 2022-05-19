using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web411031246.ViewModels;

namespace Web411031246.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View(new SignUPdata());
        }
        [HttpPost]
        public ActionResult SignUp(SignUPdata data)
        {
           /* if (data.Name.IsNullOrWhiteSpace())
            {
                data.Namemessage = "请输入名字";
            }
            if (data.Acconut.IsNullOrWhiteSpace())
            {
                data.AccountMessage = "请输入账号";

            }
            if (data.Password.IsNullOrWhiteSpace())
            {
                data.PasswordMessage = "请输入密码";

            }*/
           if(ModelState.IsValid)
            if (!data.Name.IsNullOrWhiteSpace() && !data.Acconut.IsNullOrWhiteSpace() && !data.Password.IsNullOrWhiteSpace())
            {
                data.Message = "注册成功";
            }
            return View(data);
            
        }
        
        
    }
}