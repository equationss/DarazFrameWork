//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DarazFrameWork
//{
//    [TestClass]
//    public class Execution
//    {
//        [AssemblyInitialize]
//        public static void AssemblyStart(TestContext TestContext)
//        {
//            LoginObjects log = new LoginObjects();
            
//            Base.Driver("Chrome");

//            log.sendLoginDetails("CjBilly06", "bootcamp");

//        }
//        [AssemblyCleanup]
//        public static void AssemblyEnd()
//        {
//            Base.Close();
//        }


//        [TestMethod]
//        public void TestMethod1()
//        {
//            Search_TM search = new Search_TM();
//            BookHotel_TM bk = new BookHotel_TM();
//            search.SearchUsingValidData();
//            bk.bookWithValidData();

//        }
//    }
//}
    
