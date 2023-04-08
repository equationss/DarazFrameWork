using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarazFrameWork.SearchBar
{
    [TestClass]
    public class SearchMethod : Base
    {
        SearchObjects objects = new SearchObjects();
        [TestMethod]
        public void SearchQuerry()
        {
            Driver("Chrome");
            objects.Search("Cup Flask");
            objects.Sort("1000","2000");



           
            //objects.Sort("Price low to high");

        }
    }
}
