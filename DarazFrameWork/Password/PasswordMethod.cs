﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.Password
{
    [TestClass]
    public class PasswordMethod : Base
    {
        PasswordObjects obj = new PasswordObjects();
        [TestMethod]
        public void PassChange()
        {
            obj.pass("bootcamp123", "BootCamp@123");
        }
    }
}