using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.CartDel
{
    public class CartDelObjects : Base
    {
        By CheckBox = By.XPath("//input[@type='checkbox']");
        By DelField = By.ClassName("list-header-operation-text");
        By RemoveAlert = By.ClassName("ok");


        public void Del()
        {
            driver.Navigate().GoToUrl("https://cart.daraz.pk/cart");
            IWebElement checkbox = driver.FindElement(CheckBox);
            checkbox.Click();

            ClickElement(DelField);
            ClickElement(RemoveAlert);
        }
    }
}
