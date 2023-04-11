using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        //By Val = By.XPath("//*[@id=\"container\"]/div/div/div[1]/div");
        By Validate = By.XPath("(//button[@type='button'])[2]");


        public void Del()
        {
            driver.Navigate().GoToUrl("https://cart.daraz.pk/cart");
            IWebElement checkbox = driver.FindElement(CheckBox);
            checkbox.Click();

            ClickElement(DelField);
            ClickElement(RemoveAlert);

            IWebElement button = driver.FindElement(Validate);
            Assert.IsTrue(button.Displayed);

            //IWebElement element = driver.FindElement(Val);
            //string expected = element.GetAttribute("value").ToString();
            //string actualText = "There are no items in this cart";
            //Console.Write(expected);
            ////string expectedText = ;
            //Assert.AreEqual(expected, actualText, "The text of the element is not as expected");
        }
    }
}
