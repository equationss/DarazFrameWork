using OpenQA.Selenium;
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

        }
    }
}
