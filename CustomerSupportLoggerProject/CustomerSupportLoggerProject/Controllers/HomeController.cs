using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerSupportLoggerProject.Models;

namespace CustomerSupportLoggerProject.Controllers
{
    public class HomeController : Controller
    {
        CustomerDetailEntities1 db = new CustomerDetailEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(UserInfo log)
        {
            var user = db.UserInfoes.Where(x => x.UserId == log.UserId && x.Password == log.Password).Count();
            if (user > 0)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Dashboard()
        {
            CustLogInfo c = new CustLogInfo();
            return View(c);
        }
        [HttpPost]
        public ActionResult Dashboard(CustLogInfo cust)
        {
            CustLogInfo cs = new CustLogInfo();
            cs.LogId = cust.LogId;
            cs.CustEmail = cust.CustEmail;
            cs.CustName = cust.CustName;
            cs.LogStatus = cust.LogStatus;
            cs.Description = cust.Description;
            db.CustLogInfoes.Add(cs);
            db.SaveChanges();
            Response.Write("<script> alert('complaint registered successfully')</script>");
            return View();

        }
    }
}