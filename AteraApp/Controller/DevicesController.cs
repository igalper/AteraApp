using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Models;
using System.Web.Script.Serialization;
using System.Web.Http.Results;
using System.Web;

namespace AteraApp
{
    public class DevicesController : ApiController
    {
        [Route("Devices/GetAllDevices")]
        [HttpGet]
        public JsonResult<List<Device>> GetAllDevices()
        {
            var dataQueries = new DAL.DataQueries();
            return Json(dataQueries.GetAllDevices());
        }

        [Route("Devices/GetDevicesByOwnerName")]
        [HttpPost]
        public JsonResult<List<Device>> GetDevicesByOwnerName()
        {
            string owner = HttpContext.Current.Request.Form["owner"];
            if (owner == null)
                throw new HttpException(400, "Invalid values");
            var dataQueries = new DAL.DataQueries();
            return Json(dataQueries.GetDevicesByOwnerName(owner));
        }

        [Route("Devices/GetDeviceById")]
        [HttpPost]
        public JsonResult<Device> GetDeviceById()
        {
            int id;
            Device res;
            if (Int32.TryParse(HttpContext.Current.Request.Form["id"], out id) && id > 0)
            {
                var dataQueries = new DAL.DataQueries();
                res = dataQueries.GetDeviceById(id);
            }
            else
            {
                throw new HttpException(400, "Invalid values");
            }
            return Json(res);
        }

        [Route("Devices/GetAllDevicesByName")]
        [HttpPost]
        public JsonResult<List<Device>> GetAllDevicesByName()
        {
            string deviceName = HttpContext.Current.Request.Form["deviceName"];
            if (deviceName == null)
                throw new HttpException(400, "Invalid values");
            var dataQueries = new DAL.DataQueries();
            return Json(dataQueries.GetDevicesByOwnerName(deviceName));
        }

        [Route("Devices/GetAllDevicesFromDateToDate")]
        [HttpPost]
        public JsonResult<List<Device>> GetAllDevicesFromDateToDate()
        {
            DateTime fromDate;
            DateTime tillDate;
            List<Device> deviceList;
            if (DateTime.TryParse(HttpContext.Current.Request.Form["fromDate"],out fromDate))
            {
                if(!DateTime.TryParse(HttpContext.Current.Request.Form["tillDate"], out tillDate))
                {
                    tillDate = DateTime.Now;
                }
                var dataQueries = new DAL.DataQueries();
                deviceList = dataQueries.GetAllDevicesFromDateToDate(fromDate,tillDate);
            }
            else
            {
                throw new HttpException(400, "Invalid values");
            }
            return Json(deviceList);
        }


    }
}