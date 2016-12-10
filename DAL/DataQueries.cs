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

        public static string GenerateDeviceUniqueName(Device device)
        {
            if (device == null)
                throw new InvalidArgsException();
            return $"{device.Id}_{device.Name}_{device.Owner}_{device.Created}";
        }

        public int DaysSinceDeviceWasCreated(Device device)
        {
            if (device == null || device.Created > DateTime.Now)
                throw new InvalidArgsException();
            return (DateTime.Now - device.Created).Days;
        }

        public Device GetDeviceById(int id)
        {
            Device device;
            using (var db = new MasterEntities())
            {
                device =
                       (from d in db.Devices
                        where d.Id == id
                        select d).FirstOrDefault();
            }
            return device;
        }
        public List<Device> GetAllDevicesByName(string deviceName)
        {
            List<Device> devicesList = new List<Device>();
            using (var db = new MasterEntities())
            {
                devicesList =
                            (from d in db.Devices
                             where d.Name == deviceName
                             select d).ToList();
            }
            return devicesList;
        }
        public List<Device> GetAllDevicesFromDateToDate(DateTime fromDate, DateTime tillDate)
        {
            List<Device> devicesList = new List<Device>();
            using (var db = new MasterEntities())
            {
                devicesList =
                            (from d in db.Devices
                             where d.Created >= fromDate && d.Created <= tillDate
                             select d).ToList();
            }
            return devicesList;
        }

        public int getNumberOfDevices()
        {
            using (var db = new MasterEntities())
            {
                int count = 0;
                foreach (Device d in db.Devices)
                    count++;

                return count;
            }
        }

    }

    public class InvalidArgsException : Exception
    {
        public InvalidArgsException() : base()
        {

        }
    }
}
