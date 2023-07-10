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
        By Validate = By.XPath("//small[text()='Default Shipping Address']");

        //By Province = By.XPath("//*[@id=\"dialog-body-4\"]/div[2]/div/form/div/div[1]/div[1]/div[3]/span/span");
        //By list = By.XPath("//li[@value='R3780131---Khyber Pakhtunkhwa']/following-sibling::li[1]");
        By label = By.XPath("//div[@class='mod-address-tag-content']//div[1]");
        //By move = By.ClassName("mod-address-tag-title");
        By City = By.XPath("//label[text()='City']/following-sibling::span");
        ///By list2 = By.CssSelector("li#RPK3");
        By Area = By.XPath("//label[text()='Area']/following-sibling::span");
        //By list3 = By.XPath("//li[@value='RPK6423---Muslim Colony']");
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


            
            IWebElement dropdown = driver.FindElement(Province);
            dropdown.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath("//div[contains(@class,'next-menu ver')]")));
            IWebElement option = driver.FindElement(By.Name("Punjab"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", option);
            option.Click();
            // option.Click();

            //WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ClickElement(label);
            //Thread.Sleep(1000);

            IWebElement dropdown2 = driver.FindElement(City);
            dropdown2.Click();
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait2.Until(ExpectedConditions.ElementExists(By.XPath("//div[contains(@class,'next-menu ver')]")));
            IWebElement option2 = driver.FindElement(By.Name("Abdul Hakim"));
            option2.Click();

            IWebElement checkbox = driver.FindElement(CheckBox1);
            checkbox.Click();

            IWebElement checkbox2 = driver.FindElement(CheckBox2);
            checkbox2.Click();


            IWebElement dropdown3 = driver.FindElement(Area);
            dropdown3.Click();
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait3.Until(ExpectedConditions.ElementExists(By.XPath("//div[contains(@class,'next-menu ver')]")));
            IWebElement option3 = driver.FindElement(By.Name("Abdul Hakim"));
            option3.Click();

            //// Locate the province dropdown and select "Punjab"
            //IWebElement provinceDropdown = driver.FindElement(Province);
            //SelectElement selectProvinceDropdown = new SelectElement(provinceDropdown);
            //selectProvinceDropdown.SelectByText("Punjab");

            //// Wait for the city dropdown options to load
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementExists(City));

            //// Locate the city dropdown and select "Abdul Hakim"
            //IWebElement cityDropdown = driver.FindElement(City);
            //SelectElement selectCityDropdown = new SelectElement(cityDropdown);
            //selectCityDropdown.SelectByText("Abdul Hakim");

            //// Wait for the area dropdown options to load
            //wait.Until(ExpectedConditions.ElementExists(Area));

            //// Locate the area dropdown options and find the option with text "Abdul Hakim"
            //IWebElement areaDropdown = driver.FindElement(Area);
            //SelectElement selectAreaDropdown = new SelectElement(areaDropdown);
            //bool isOptionFound = false;
            //foreach (IWebElement option in selectAreaDropdown.Options)
            //{
            //    if (option.Text == "Abdul Hakim")
            //    {
            //        selectAreaDropdown.SelectByText("Abdul Hakim");
            //        isOptionFound = true;
            //        break;
            //    }
            //}

            //// If the "Abdul Hakim" option is not found, select the first available option
            //if (!isOptionFound)
            //{
            //    selectAreaDropdown.SelectByIndex(0);
            //}








            // FindElement(Province);
            //ClickElement(Province);
            //SendKeys("\u0050");
            //Keys.Control


            //IWebElement firstDropdown = driver.FindElement(Province);
            //firstDropdown.Click();
            //firstDropdown.SendKeys("\u0050");
            //firstDropdown.SendKeys(Keys.Enter);
            //SelectElement selectFirstDropdown = new SelectElement(firstDropdown);
            //selectFirstDropdown.Keys
            //selectFirstDropdown.SelectByText("Punjab");

            //// Wait until page is loaded completely
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            //// Wait until second dropdown is activated
            //IWebElement secondDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(City));

            //// Select a value from the second dropdown
            //SelectElement selectSecondDropdown = new SelectElement(secondDropdown);
            //selectSecondDropdown.SelectByText("Abdul Hakim");

            //// Wait until page is loaded completely
            //wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            //// Wait until second dropdown is activated again
            //secondDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(Area));


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







            //Scroll(move);




            //IWebElement city = driver.FindElement(City);
            //city.Click();

            //IWebElement select2 = driver.FindElement(list2);
            //select2.Click();

            //IWebElement area = driver.FindElement(Area);
            //city.Click();

            //IWebElement select3 = driver.FindElement(list3);
            //select3.Click();



            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            //IWebElement myElement = wait.Until(ExpectedConditions.ElementIsVisible(CheckBox2));

            ClickElement(SubmitBtn);
            //IWebElement element = driver.FindElement(Validate);
            //string text = element.Text;
            //Console.WriteLine(text);

            // Assertion Code

           // IWebElement element = driver.FindElement(Validate);
            //string actualText = element.Text;
            //string expectedText = "Default Shipping Address";
//            Assert.AreEqual(expectedText, actualText, "The text of the element is not as expected"); 


            //WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //wait4.Until(ExpectedConditions.TitleContains("Raja Junaid"));

            //string CurrentTittle = driver.Title.ToString();
            //Console.Write(CurrentTittle);
            ////Console.WriteLine("The current URL is: " + currentUrl);

            //// add a delay to avoid overloading the browser
            ////    Thread.Sleep(1000);
            ////}
            ////string currentUrl = driver.CurrentUrl;
            //string expected = "Raja Junaid";
            //Assert.AreEqual(expected, CurrentTittle);


        }

    }
}
