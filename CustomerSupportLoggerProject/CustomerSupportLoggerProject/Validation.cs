using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerSupportLoggerProject.Models;

namespace CustomerSupportLoggerProject
{
    public class Validation
    {
        CustomerDetailEntities1 db = new CustomerDetailEntities1();
        public bool check()
        {
            bool ans = false;
            var found = db.UserInfoes.ToList();
            if (found[0].UserId == 1 && found[0].Email == "sk.naren@gmail.com")
            {
                ans = true;
            }
            return ans;
        
         
        }
    }
}