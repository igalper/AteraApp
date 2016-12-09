using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Tests
{
    [TestClass()]
    public class DataQueriesTests
    {
        [TestMethod()]
        public void DaysSinceDeviceWasCreatedTest()
        {
            Device device = new Device()
            {
                Created = DateTime.Now.AddDays(-45),
                Id = 11,
                Name = "Igal's Device",
                Owner = "Igal"
            };

            DAL.DataQueries dal = new DAL.DataQueries();

            int days = dal.DaysSinceDeviceWasCreated(device);
            Console.WriteLine(days);

            Assert.IsTrue(days == 45);
        }

        [TestMethod()]
        public void GenerateDeviceUniqueNameTest()
        {
            Device device = new Device()
            {
                Created = DateTime.Now.AddDays(-45),
                Id = 11,
                Name = "Igal's Device",
                Owner = "Igal"
            };

            string result = DAL.DataQueries.GenerateDeviceUniqueName(device);

            //  Assert.IsInstanceOfType(result, T(string)
            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.IsTrue(result == $"{device.Id}_{device.Name}_{device.Owner}_{device.Created}");



        }

    }
}