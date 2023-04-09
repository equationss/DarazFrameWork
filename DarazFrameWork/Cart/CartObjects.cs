using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void Cart(string Search)
        {
            ClickElement(logo);
            FindElement(SearchField);
            SendKeys(SearchField, Search);
            ClickElement(SearchBtn);
            ClickElement(Field1);
            ClickElement(AddCartField);

        }
        public void cartlogin(string Email, string Password)
        {
            FindElement(EmailField);
            SendKeys(EmailField, Email);
            FindElement(PasswordField);
            SendKeys(PasswordField, Password);
            ClickElement(LoginBtn);

        }
        //Scroll(scroll);
        //ClickElement(Element1);

    }
}

