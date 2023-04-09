using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.Password
{
    public class PasswordObjects : Base
    {
        By UserAccount = By.CssSelector("li#My-profile>a");
        By ChangePassBtn = By.XPath("(//div[@class='my-profile-ft']//a)[3]");
        By CurrentField = By.XPath("//input[@data-meta='Field']");
        By NewField = By.XPath("(//input[@type='password'])[2]");
        By ReTypeField = By.XPath("(//input[@type='password'])[3]");
        By SubmitBtn = By.XPath("(//button[@type='button'])[2]");
        By OkBtn = By.XPath("(//button[@type='button'])[3]");
        By Alert = By.XPath("//div[@role='alertdialog']");


        public void pass(string Old, string New)
        {
            ClickElement(UserAccount);
            ClickElement(ChangePassBtn);
            FindElement(CurrentField);
            SendKeys(CurrentField, Old);
            FindElement(NewField);
            SendKeys(NewField, New);
            FindElement(ReTypeField);
            SendKeys(ReTypeField, New);
            ClickElement(SubmitBtn);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //var alert = wait.Until(ExpectedConditions.AlertIsPresent());
            //Assert.IsTrue(alert.Text.Contains("Success"));
            //alert.Accept();

            var successMessage = wait.Until(ExpectedConditions.ElementIsVisible(Alert));

            // Verify that the success message is displayed on the page
            Assert.IsTrue(successMessage.Displayed);
            //successMessage.Accept();

            ClickElement(OkBtn);
        }
    }
}
