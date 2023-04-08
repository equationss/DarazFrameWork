using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.Login
{
    [TestClass]
    public class LoginMethod : Base
    {
        public TestContext TestContext { get; set; }

        LoginObjects Object = new LoginObjects();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Daraz.csv", "Daraz#csv", DataAccessMethod.Sequential)]
        public void ValidLogin()
        {
            string user = TestContext.DataRow["User"].ToString();
            string pass = TestContext.DataRow["Pass"].ToString();
            Driver("Chrome");
            driver.Navigate().GoToUrl("https://member.daraz.pk/user/login");
            //Object.login("TestProject@mailinator.com","bootcamp123");
            Object.login(user, pass);
            Object.loginValidate();


        }
    }
}
