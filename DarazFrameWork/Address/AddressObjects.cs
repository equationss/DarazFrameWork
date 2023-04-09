using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.Address
{
    public class AddressObjects : Base
    {
        By EditBtn = By.CssSelector("li#Address-book>a");
        By NewAdd = By.XPath("//span[text()='Add New Address']");
        By NameField = By.XPath("//input[@placeholder='Input full name']");
        By AddField = By.XPath("//input[@placeholder='House no. / building / street / area']");
        By NumField = By.XPath("//input[@inputmode='numeric']");
        By LandmarkField = By.CssSelector("div#dialog-body-1>div:nth-of-type(2)>div>form>div>div>div:nth-of-type(2)>div:nth-of-type(2)>input");
        By Province = By.XPath("//i[contains(@class,'next-icon next-icon-arrow-down')]");
        By list = By.XPath("//li[@value='R3780131---Khyber Pakhtunkhwa']/following-sibling::li[1]");
        By label = By.XPath("//span[@data-spm-anchor-id='a2a0e.address_book.0.i4.47ed7d68NmxxjY']");
        By move = By.ClassName("mod-address-tag-title");
        By City = By.XPath("//div[@class='mod-address-tag-content']//div[1]");
        By list2 = By.CssSelector("li#RPK3");
        By Area = By.XPath("(//span[@class='next-select large']//span)[3]");
        By list3 = By.XPath("//li[@value='RPK6423---Muslim Colony']");
        By CheckBox1 = By.XPath("//span[@class='next-checkbox-label']");
        By CheckBox2 = By.XPath("(//span[@class='next-checkbox-label'])[2]");
        By SubmitBtn = By.XPath("//button[@type='submit']");
        public void EditAddr(string name, string add, string num, string lan)
        {
            ClickElement(EditBtn);
            ClickElement(NewAdd);
            FindElement(NameField);
            SendKeys(NameField, name);
            FindElement(AddField);
            SendKeys(AddField, add);
            FindElement(NumField);
            SendKeys(NumField, num);
            FindElement(LandmarkField);
            SendKeys(LandmarkField, lan);


            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //IWebElement myElement = wait.Until(ExpectedConditions.ElementIsVisible(Province));
            IWebElement province = driver.FindElement(Province);
            province.Click();

            //Dropdown(Province, "text", "Punjab");


            IWebElement select = driver.FindElement(list);
            select.Click();


            ClickElement(label);
            



            //Scroll(move);

            IWebElement city = driver.FindElement(City);
            city.Click();

            IWebElement select2 = driver.FindElement(list2);
            select2.Click();

            IWebElement area = driver.FindElement(Area);
            city.Click();

            IWebElement select3 = driver.FindElement(list3);
            select3.Click();

            IWebElement checkbox = driver.FindElement(CheckBox1);
            checkbox.Click();

            IWebElement checkbox2 = driver.FindElement(CheckBox2);
            checkbox2.Click();

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //IWebElement myElement = wait.Until(ExpectedConditions.ElementIsVisible(CheckBox2));

            ClickElement(SubmitBtn);
        }

    }
}
