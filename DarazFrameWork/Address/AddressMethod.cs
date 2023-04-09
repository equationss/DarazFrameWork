using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    [TestClass]
    public class AddressMethod : Base
    {
        AddressObjects Obj = new AddressObjects();

        [TestMethod]
        public void add()
        {
            Obj.EditAddr("Raja Junaid","Summan Burj","03113117444","Logic School");
            //Obj.province("Punjab");
            //Obj.click();
        }

    }
}
