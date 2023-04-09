using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        By Province = By.XPath("//label[text()='Province']/following-sibling::span");
        By list = By.XPath("//li[@value='R3780131---Khyber Pakhtunkhwa']/following-sibling::li[1]");
        By label = By.XPath("//div[@class='mod-address-tag-content']//div[1]");
        By move = By.ClassName("mod-address-tag-title");
        By City = By.XPath("//label[text()='City']/following-sibling::span");
        By list2 = By.CssSelector("li#RPK3");
        By Area = By.XPath("//label[text()='Area']/following-sibling::span");
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


            IWebElement firstDropdown = driver.FindElement(Province);
            SelectElement selectFirstDropdown = new SelectElement(firstDropdown);
            selectFirstDropdown.SelectByText("Punjab");

            // Wait until page is loaded completely
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            // Wait until second dropdown is activated
            IWebElement secondDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(City));

            // Select a value from the second dropdown
            SelectElement selectSecondDropdown = new SelectElement(secondDropdown);
            selectSecondDropdown.SelectByText("Abdul Hakim");

            // Wait until page is loaded completely
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            // Wait until second dropdown is activated again
            secondDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(Area));


            //try
            //{
            //    IWebElement spanElement = driver.FindElement(Province);
            //    string script = "arguments[0].innerText = 'Punjab';";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script, spanElement);
            //    Console.WriteLine("Province set successfully.");


            //    IWebElement spanElement2 = driver.FindElement(City);
            //    string script2 = "arguments[0].innerText = 'Abdul Hakim';";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script2, spanElement2);
            //    Console.WriteLine("City set successfully.");

            //    IWebElement spanElement3 = driver.FindElement(Area);
            //    string script3 = "arguments[0].innerText = 'Abdul Hakim';";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script3, spanElement3);
            //    Console.WriteLine("Area set successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.Write("Error: " + ex.Message);
            //}

            //var ProDrop = driver.FindElement(Province);
            //var selectDrop = new SelectElement(ProDrop);
            //selectDrop.SelectByValue("Punjab");
            //Console.Write(selectDrop.ToString());
            //Thread.Sleep(5000);

            //try
            //{
            //    // Set Province
            //    IWebElement provinceElement = driver.FindElement(Province);
            //    string script1 = "arguments[0].click(); arguments[1].querySelector(\"[data-text='Punjab']\").click();";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script1, provinceElement, driver);

            //    Console.WriteLine("Province set successfully.");

            //    // Wait for the City field to become active
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //    IWebElement cityElement = wait.Until(ExpectedConditions.ElementToBeClickable(City));

            //    // Set City
            //    string script2 = "arguments[0].click(); arguments[1].querySelector(\"[data-text='Abdul Hakim']\").click();";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script2, cityElement, driver);

            //    Console.WriteLine("City set successfully.");

            //    // Wait for the Area field to become active
            //    IWebElement areaElement = wait.Until(ExpectedConditions.ElementToBeClickable(Area));

            //    // Set Area
            //    string script3 = "arguments[0].click(); arguments[1].querySelector(\"[data-text='Abdul Hakim']\").click();";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script3, areaElement, driver);

            //    Console.WriteLine("Area set successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}



            //try
            //{
            //    // Set Province
            //    IWebElement provinceElement = driver.FindElement(Province);
            //    string script1 = "arguments[0].click(); arguments[1].querySelector(\"[data-text='Punjab']\").click();";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script1, provinceElement, driver);

            //    Console.WriteLine("Province set successfully.");

            //    // Wait for the City field to become active
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //    IWebElement cityElement = wait.Until(ExpectedConditions.ElementToBeClickable(City));

            //    // Set City
            //    string script2 = "arguments[0].click(); arguments[1].querySelector(\"[data-text='Abdul Hakim']\").click();";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script2, cityElement, driver);

            //    Console.WriteLine("City set successfully.");

            //    // Wait for the Area field to become active
            //    IWebElement areaElement = wait.Until(ExpectedConditions.ElementToBeClickable(Area));

            //    // Set Area
            //    string script3 = "arguments[0].click(); arguments[1].querySelector(\"[data-text='Abdul Hakim']\").click();";
            //    ((IJavaScriptExecutor)driver).ExecuteScript(script3, areaElement, driver);

            //    Console.WriteLine("Area set successfully.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}







            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //IWebElement myElement = wait.Until(ExpectedConditions.ElementIsVisible(Province));
            //IWebElement province = driver.FindElement(Province);
            //province.Click();

            //IWebElement provinceDropdown = driver.FindElement(Province);
            //SelectElement select = new SelectElement(provinceDropdown);
            //select.SelectByIndex(7); // selects the third option

            //Dropdown(Province, "text", "Punjab");


            //IWebElement select = driver.FindElement(list);
            //select.Click();
            //public void province(string place)
            //{
            //  FindElement(Province, 60);
            //Dropdown(Province, "value", place);
            //}


            ClickElement(label);




            //Scroll(move);

            


            //IWebElement city = driver.FindElement(City);
            //city.Click();

            //IWebElement select2 = driver.FindElement(list2);
            //select2.Click();

            //IWebElement area = driver.FindElement(Area);
            //city.Click();

            //IWebElement select3 = driver.FindElement(list3);
            //select3.Click();

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
