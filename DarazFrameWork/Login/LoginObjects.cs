using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DarazFrameWork.Login
{

    public class LoginObjects : Base
    {
        //By LoginField = By.XPath("(//a[@class='grey'])[3]");
        By EmailField = By.XPath("//label[text()='Phone Number or Email']/following::input");
        By PasswordField = By.XPath("//label[text()='Password']/following::input");
        By LoginBtn = By.XPath("//button[text()='LOGIN']");
        //By Validation = By.CssSelector("//div[@class='member-info']//p[1]");


        //By Validation = By.XPath("//div[@id='lzdMyAccountPop']/div[1]/ul[1]/li[6]/a[1]");
        public void login(string Email, string Password)
        {
            //Click(LoginField);
            FindElement(EmailField);
            SendKeys(EmailField, Email);
            FindElement(PasswordField);
            SendKeys(PasswordField, Password);
            ClickElement(LoginBtn);
        }

        //IWebElement Label = driver.FindElement(Validation);
        //string text= Label.Text;

        //while (true)
        //{
        public void loginValidate()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.TitleContains("Manage My Account"));

            string CurrentTittle = driver.Title.ToString();
            Console.Write(CurrentTittle);
            //Console.WriteLine("The current URL is: " + currentUrl);

            // add a delay to avoid overloading the browser
            //    Thread.Sleep(1000);
            //}
            //string currentUrl = driver.CurrentUrl;
            string expected = "Manage My Account";
            Assert.AreEqual(expected, CurrentTittle);

            //Close();
        }

        //GetElementText(Validation);

        ////ClickWebElement(Validation);
        //try
        //{
        //    IWebElement dropdownElement = driver.FindElement(Validation);
        //    SelectElement dropdown = new SelectElement(dropdownElement);
        //    dropdown.SelectByValue("Logout");
        //    IWebElement selectedOption = dropdown.SelectedOption;
        //    string selectedOptionText = selectedOption.Text;
        //    Console.Write("Selected option: " + selectedOptionText);
        //}
        //catch (UnexpectedTagNameException e)
        //{
        //    Console.WriteLine("Error: " + e.Message);
        //}


        //public void validation(string valid)
        //{
        //    FindElement(Validation, 60);
        //    Dropdown(Validation, "value", valid);
        //}



        //IWebElement element = driver.FindElement(Validation);
        //string text = element.Text;
        //string expectedText = "Logout";

        //Assert.AreEqual(expectedText, text, "The actual text does not match the expected text");
        //Dropdown(Validation,"index",Manage)


        //bool isLoggedIn = IsElementDisplayed(Validation);

        //if (isLoggedIn)
        //{
        //    Console.Write("Login successful!");
        //}
        //else
        //{
        //    Console.Write("Login failed.");
        //}


        //Close();
    }
}


