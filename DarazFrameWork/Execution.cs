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
using DarazFrameWork.Cart;
using System.Threading;
using DarazFrameWork.Address;
using DarazFrameWork.Password;
using DarazFrameWork.FlashSale;

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
            log.login("TestProject@mailinator.com", "Test123");
            log.loginValidate();

        }
        [AssemblyCleanup]
        public static void AssemblyEnd()
        {
            Base.Close();
        }


        [TestMethod]
        public void Run()
        {
            
            //AddressMethod address = new AddressMethod();
            //address.add();

            //SearchMethod search = new SearchMethod();
            //search.SearchQuerry();

            //PasswordMethod method = new PasswordMethod();
            //method.PassChange();

            //CartMethod cart = new CartMethod();
            //cart.Cart();

            FlashSaleMethod flashSaleMethod = new FlashSaleMethod();
            flashSaleMethod.sale();



        }
    }
}

