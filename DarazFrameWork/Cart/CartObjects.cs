using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DarazFrameWork.Cart
{
    public class CartObjects : Base
    {
        By logo = By.XPath("//img[@alt='Daraz']");
        By SearchField = By.Id("q");
        By SearchBtn = By.ClassName("search-box__button--1oH7");
        //By Element1 = By.XPath("//img[@src='https://gcp-img.slatic.net/lazada/7f7b4f20-49b9-4ad3-903d-c12b62a67b17_PK-388-180.png']");
        //By scroll = By.ClassName("fs-status-text");
        By Field1 = By.LinkText("WILMAX ENGLAND Double Wall Thermo Glass Mug 400 ML");
        By AddCartField = By.XPath("//span[text()='Add to Cart']");
        By EmailField = By.XPath("//input[@placeholder='Please enter your Phone Number or Email']");
        By PasswordField = By.XPath("(//input[@data-meta='Field'])[2]");
        By LoginBtn = By.XPath("//button[text()='LOGIN']");
        By Field2 = By.XPath("//div[@class='box--pRqdD boxWithSku--Abyff']");
        By cart = By.XPath("//button[contains(@class,'next-btn next-btn-secondary')]");
        By Field3 = By.XPath("//div[@class='box--pRqdD']");
        By Field4 = By.XPath("//div[@class='box--pRqdD']");
        By Field5 = By.XPath("//div[@class='box--pRqdD']");
        By CheckBox = By.XPath("//input[@type='checkbox']");
        By DelField = By.ClassName("list-header-operation-text");
        By RemoveAlert = By.ClassName("ok");
        By Val = By.XPath("//div[text()='There are no items in this cart']");
        public void Cart(string Search, string Search2, string Search3, string Search4, string Search5)
        {
            ClickElement(logo);
            FindElement(SearchField);
            SendKeys(SearchField, Search);
            ClickElement(SearchBtn);
            ClickElement(Field1);
            ClickElement(AddCartField);
            Thread.Sleep(1000);
            
            back();

            FindElement(SearchField);
            SendKeys(SearchField, Search2);
            ClickElement(SearchBtn);
            ClickElement(Field2);
            ClickElement(AddCartField);
            Thread.Sleep(1000);

            back();

            FindElement(SearchField);
            SendKeys(SearchField, Search3);
            ClickElement(SearchBtn);
            ClickElement(Field3);
            ClickElement(AddCartField);
            Thread.Sleep(1000);

            back();


            FindElement(SearchField);
            SendKeys(SearchField, Search4);
            ClickElement(SearchBtn);
            ClickElement(Field4);
            ClickElement(AddCartField);
            Thread.Sleep(1000);

            back();

            FindElement(SearchField);
            SendKeys(SearchField, Search5);
            ClickElement(SearchBtn);
            ClickElement(Field5);
            ClickElement(AddCartField);
            Thread.Sleep(1000);

            driver.Navigate().GoToUrl("https://cart.daraz.pk/cart");

            IWebElement checkbox = driver.FindElement(CheckBox);
            checkbox.Click();

            ClickElement(DelField);
            ClickElement(RemoveAlert);

            //IWebElement element = driver.FindElement(Val);
            //string actualText = element.Text;
            //Console.Write(actualText);
            //string expectedText = "There are no items in this cart";
            //Assert.AreEqual(expectedText, actualText, "The text of the element is not as expected");

        }
        //public void cartlogin(string Email, string Password)
        //{
        //    FindElement(EmailField);
        //    SendKeys(EmailField, Email);
        //    FindElement(PasswordField);
        //    SendKeys(PasswordField, Password);
        //    ClickElement(LoginBtn);

        //}
        //Scroll(scroll);
        //ClickElement(Element1);

    }
}

