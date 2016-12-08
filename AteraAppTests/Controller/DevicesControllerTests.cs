using Microsoft.VisualStudio.TestTools.UnitTesting;
using AteraApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AteraApp.Tests
{
    [TestClass()]
    public class DevicesControllerTests
    {
        [TestMethod()]
        public void GetStringFromTestControllerMethod()
        {
            DevicesController dc = new DevicesController();

            string strResult = dc.getAllDevices();

            Assert.IsFalse(string.IsNullOrEmpty(strResult));
        }

        [TestMethod()]
        public void GetStringFromTestControllerMethodAssertFail()
        {
            DevicesController dc = new DevicesController();

            string strResult = dc.getAllDevices();

            Assert.IsNull(strResult);
        }


    }
}