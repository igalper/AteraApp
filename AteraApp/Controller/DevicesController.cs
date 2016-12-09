using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Models;
using System.Web.Script.Serialization;
using System.Web.Http.Results;

namespace AteraApp
{
    public class DevicesController : ApiController
    {
        //[Route("Devices/GetAllDevices")]
        [HttpGet]
        public JsonResult<List<Device>> GetAllDevices()
        {
            var dataQueries = new DAL.DataQueries();
            return Json(dataQueries.GetAllDevices());
        }

        //[Route("Devices/GetDevicesByOwnerName")]
        [HttpPost]
        public JsonResult<List<Device>> GetDevicesByOwnerName(string owner)
        {
            var dataQueries = new DAL.DataQueries();
            return Json(dataQueries.GetDevicesByOwnerName(owner));
        }


        [HttpPost]
        public JsonResult<Device> GetDeviceById(int id)
        {
            var dataQueries = new DAL.DataQueries();
            return Json(dataQueries.GetDeviceById(id));
        }

        [HttpPost]
        public JsonResult<List<Device>> GetAllDevicesByName(string deviceName)
        {
            var dataQueries = new DAL.DataQueries();
            return Json(dataQueries.GetAllDevicesByName(deviceName));
        }

        [HttpPost]
        public JsonResult<List<Device>> GetAllDevicesFromDateToDate(DateTime fromDate, DateTime tillDate)
        {
            var dataQueries = new DAL.DataQueries();
            return Json(dataQueries.GetAllDevicesFromDateToDate(fromDate,tillDate));
        }


    }
}