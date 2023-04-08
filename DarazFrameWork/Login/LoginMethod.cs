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
        LoginObjects Object = new LoginObjects();

        [TestMethod]
        public void ValidLogin()
        {
            Driver("Chrome");
            driver.Navigate().GoToUrl("https://member.daraz.pk/user/login");
            Object.login("TestProject@mailinator.com","bootcamp123");
         

        }
    }
}
