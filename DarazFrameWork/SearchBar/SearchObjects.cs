using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarazFrameWork.SearchBar
{
    public class SearchObjects : Base
    {
        By SearchField = By.Id("q");
        By SearchBtn = By.ClassName("search-box__button--1oH7");
        By Category = By.LinkText("Drink Bottles");
        By SortDropDown = By.ClassName("ant-select-arrow");
        By List = By.XPath("//li[@title='Price low to high']//div[1]");
        By Move = By.XPath("//div[text()='Service']");
        By MiniField = By.XPath("//input[@min='0']");
        By MaxField = By.XPath("//input[@placeholder='Max']");
        By SubmitBtn = By.XPath("(//button[@type='button'])[2]");
        By Pic = By.ClassName("box--LNmE6");
        By Val = By.XPath("(//span[text()='Rs. 1,000'])[1]");



        public void Search(string Search)
        {
            FindElement(SearchField);
            SendKeys(SearchField, Search);
            ClickElement(SearchBtn);
            ClickElement(Category);
            // ClickElement(SortDropDown);
            //ClickElement(List);

            //IWebElement sortDropdown = driver.FindElement(SortDropDown);
            //sortDropdown.Click();

            //IWebElement priceLowToHigh = driver.FindElement(List);
            //priceLowToHigh.Click();
            //string Value = "Price low to high";
            //SelectElement dropDown = new SelectElement(driver.FindElement(SortDropDown));
            //dropDown.SelectByValue(Value);


            //Dropdown(SortDropDown, "value", Drop);

            //IWebElement sortDropdown = driver.FindElement(SortDropDown);
            //SelectElement select = new SelectElement(sortDropdown);
        }
        public void Sort(string min, string max)
        {

            //    string Value = "Price low to high";
            //    SelectElement dropDown = new SelectElement(driver.FindElement(SortDropDown));
            //    dropDown.SelectByValue(Value);
            //    FindElement(SortDropDown, 60);
            //    Dropdown(SortDropDown, "value", sort);
            //Dropdown(SortDropDown, "text","Price low to high");

            IWebElement sortDropdown = driver.FindElement(SortDropDown);
            sortDropdown.Click();

            IWebElement priceLowToHigh = driver.FindElement(List);
            priceLowToHigh.Click();

            Scroll(Move);

            FindElement(MiniField);
            SendKeys(MiniField, min);
            FindElement(MaxField);
            SendKeys(MaxField, max);
            ClickElement(SubmitBtn);

            Scroll(Pic);

            Thread.Sleep(5000);
            ScreenShot();

            //Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            //screenshot.SaveAsFile(@".\\Screenshot.png", ScreenshotImageFormat.Png);

            //ScreenShot();
            //var e = driver.FindElement(Move);
            //// JavaScript Executor to scroll to element
            //((IJavaScriptExecutor)driver)
            //.ExecuteScript("arguments[0].scrollIntoView(true);", e);

            /* 
              
            IWebElement element = driver.FindElement(Val);
            string actualText = element.Text;
            string expectedText = "Rs. 1,000";
            Assert.AreEqual(expectedText, actualText, "The text of the element is not as expected");
            
             */

            //Close();
        }


    }
}

