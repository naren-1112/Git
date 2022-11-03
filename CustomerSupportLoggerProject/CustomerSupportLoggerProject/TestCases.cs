using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using CustomerSupportLoggerProject.Models;

namespace CustomerSupportLoggerProject
{
    [TestFixture]
    public class TestCases
    {
        [TestCase]
        public void UserInfoTest()
        {
            CustomerDetailEntities1 db = new CustomerDetailEntities1();
            var found = db.UserInfoes.ToList();

            Assert.AreEqual(1, found[0].UserId);

        }
        [TestCase]
        public void UserInfoTest1()
        {
            CustomerDetailEntities1 db = new CustomerDetailEntities1();
            var found = db.UserInfoes.ToList();

            Assert.AreEqual("sk@96777", found[0].Password.ToString());

        }
        Validation v = new Validation();
        [TestCase]
        public void UserInfoTest2()
        {

            v.check();
        }
    }
}