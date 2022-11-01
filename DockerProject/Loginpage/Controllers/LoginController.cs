using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loginpage.Models;

namespace Loginpage.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public List<UserModel> PutValue()
        {
            var users = new List<UserModel>
            {
               new UserModel{ID=1,Username="Naren",Password="121922"},
                new UserModel{ID=2,Username="SK",Password="1211"},
                new UserModel{ID=3,Username="SKN",Password="4564"},
                new UserModel{ID=4,Username="Naren_SK",Password="9677"}
            };

            return users;
        }

        [HttpPost]
        public IActionResult Verify(UserModel user)
        {
            var U = PutValue();

            var UE = U.Where(U => U.Username.Equals(user.Username));

            var UP = UE.Where(P => P.Password.Equals(user.Password));

            if(UP.Count()==1)
            {
                ViewBag.message = "Login Success";
                return View("LoginSuccess");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Login");
            }
        }
    }
}
