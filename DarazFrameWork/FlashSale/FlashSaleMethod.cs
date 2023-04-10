using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.FlashSale
{
    [TestClass]
    public class FlashSaleMethod
    {
        FlashSaleObjects Obj= new FlashSaleObjects();

        [TestMethod]
        public void sale()
        {
            Obj.Sale("3");
        }
    }
}
