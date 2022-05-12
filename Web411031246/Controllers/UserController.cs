using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411031246.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string name,string account,string password)
        {
            if (name.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "请输入名字";
            }
            if (account.IsNullOrWhiteSpace())
            {
                ViewBag.accountMessage = "请输入账号";

            }
            if (password.IsNullOrWhiteSpace())
            {
                ViewBag.passwordMessage = "请输入密码";

            }
            if (!name.IsNullOrWhiteSpace() && !account.IsNullOrWhiteSpace() && !password.IsNullOrWhiteSpace())
            {
                ViewBag.Message = "注册成功";
            }
            return View();
            
        }
        
        
    }
}