using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataQueries
    {
        public int GetNumberOfDevices()
        {
            using (var db = new MasterEntities())
            {
                int count = 0;
                foreach (Device d in db.Devices)
                    count++;

                return count;
            }
        }

        public List<Device> GetDevicesByOwnerName(string ownerName)
        {
            List<Device> devicesList = new List<Device>();

            using (var db = new MasterEntities())
            {
                devicesList =
                    (from d in db.Devices
                     where d.Owner == ownerName       
                     select d).ToList();
            }

            return devicesList;
        }

        public List<Device> GetAllDevices()
        {
            List<Device> devicesList = new List<Device>();

            using (var db = new MasterEntities())
            {
                devicesList =
                    (from d in db.Devices
                     select d).ToList();
            }

            return devicesList;
        }

        public string GenerateDeviceUniqueName()
        {
            //TODO
            return "";
        }

        public int DaysSinceDeviceWasCreated()
        {
            //TODO
            return 0;
        }
    }
}
