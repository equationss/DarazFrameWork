using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.FlashSale
{
    public class FlashSaleObjects : Base
    {
        By item = By.XPath("(//div[contains(@class,'flash-unit card-hover')])[2]");
        By Input = By.XPath("//input[@max='3']");
        public void Sale(string Quantity)
        {
            driver.Navigate().GoToUrl("https://www.daraz.pk/flash-sale/");
            ClickElement(item);
            FindElement(Input);
            SendKeys(Input, Quantity);
            string Expected= "3";
            Assert.AreEqual(Expected, Quantity);
        }
    }
}
