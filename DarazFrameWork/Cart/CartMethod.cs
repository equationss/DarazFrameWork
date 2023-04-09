using DarazFrameWork.Login;
using DarazFrameWork.SearchBar;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DarazFrameWork.Cart
{
    [TestClass]
    public class CartMethod : Base
    {
        public TestContext TestContext { get; set; }
        CartObjects cart = new CartObjects();
        //LoginObjects Object = new LoginObjects();

        [TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Daraz.csv", "Daraz#csv", DataAccessMethod.Sequential)]
        public void Cart()
        {
            //string search = TestContext.DataRow["Search"].ToString();
            //string user = TestContext.DataRow["User"].ToString();
            //string pass = TestContext.DataRow["Pass"].ToString();
            //Driver("Chrome");
            //driver.Navigate().GoToUrl("https://www.daraz.pk/dmart/");
            //objects.Search(search);
            //driver.Navigate().GoToUrl("https://www.daraz.pk/");
            cart.Cart("Cup Flask");
            //Thread.Sleep(10000);
            //cart.cartlogin(user, pass);
            //Object.login(user,pass);
        }
    }
}
