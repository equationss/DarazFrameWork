using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DarazFrameWork.SearchBar
{
    [TestClass]
    public class SearchMethod 
    {
        public TestContext TestContext { get; set; }
        SearchObjects objects = new SearchObjects();
        [TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Daraz.csv", "Daraz#csv", DataAccessMethod.Sequential)]
        public void SearchQuerry()
        {
            //string search = TestContext.DataRow["Search"].ToString();
            //string min = TestContext.DataRow["Min"].ToString();
            //string max = TestContext.DataRow["Max"].ToString();

           // Driver("Chrome");
            objects.Search("Cup Flask");
            objects.Sort("1000","2000");




            //objects.Sort("Price low to high");

        }
    }
}
