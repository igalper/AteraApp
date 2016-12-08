using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL.Models;



namespace AteraApp
{
    public class DevicesController : ApiController
    {
        [Route("Devices")]
        [HttpPost]
        public string getAllDevices()
        {
            var dataQueries = new DAL.DataQueries();
            var res = "";
            foreach (Device d in dataQueries.GetAllDevices())
            {
                res += "{" + d.ToString()+" },";
            }
            
            return res;
        }
        [Route("Devices/{id}")]
        [HttpPost]
        public string getDevice([FromUri] int id)
        {
            var dataQueries = new DAL.DataQueries();
            var res = "";
            List<Device> deviceList = dataQueries.GetAllDevices();
            Device d = deviceList.Find(device => device.Id == id);
            res += "{" + d.ToString() + " }";
            

            return res;
        }


        // GET api/<controller>
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/<controller>/5
        /*public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<controller>
        /*public void Post([FromBody]string value)
        {
        }*/

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}