using DarazFrameWork.Login;
using DarazFrameWork.SearchBar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium.Chrome;

namespace DarazFrameWork
{
    [TestClass]
    public class Execution
    {
        //public TestContext TestContext { get; set; }
        [AssemblyInitialize]
        public static void AssemblyStart(TestContext TestContext)
        {
            LoginObjects log = new LoginObjects();

            //string user = TestContext.DataRow["User"].ToString();
            //string pass = TestContext.DataRow["Pass"].ToString();
            Base.Driver("Chrome");
            Base.driver.Navigate().GoToUrl("https://member.daraz.pk/user/login");
            //Object.login("TestProject@mailinator.com","bootcamp123");
            log.login("TestProject@mailinator.com", "bootcamp123");
            log.loginValidate();

        }
        [AssemblyCleanup]
        public static void AssemblyEnd()
        {
            Base.Close();
        }


        [TestMethod]
        public void TestMethod1()
        {
            //SearchMethod search = new SearchMethod();
            //BookHotel_TM bk = new BookHotel_TM();
            //search.SearchQuerry();
            //bk.bookWithValidData();

        }
    }
}

