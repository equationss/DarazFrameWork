using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.CartDel
{
   [TestClass]   
    
    public class CartDelMethod
    {
        CartDelObjects Cartdel = new CartDelObjects();


        [TestMethod]
        public void del()
        {
            Cartdel.Del();
        }

    }
}
