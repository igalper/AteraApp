AteraApp

description:
AteraApp main purpose is to show devices list from the Atera DB

functionality:
The top search box is for searching devices by their owner, type the owner name and press "search" button for owner filter, to go back to the full device list press the "reset" button.
The second search box is for searching inside the list.
To view the full details of a device press on the desired device and the owner name and the time created will reveal.

design:

AteraApp-
view: index.aspx
web api: DevicesController- implements all of "DataQueries" function that described below
	functions and rouths and method: **data is passed in the form-data of the request	
									[Route("Devices/GetAllDevices")]
									[HttpGet]
									GetAllDevices() get all devices by owner name 
									[Route("Devices/GetDevicesByOwnerName")]
									[HttpPost]
									GetDevicesByOwnerName() get all devices by owner name Input: {"owner":value}
									[Route("Devices/GetDeviceById")]
									[HttpPost]
									GetDeviceById() get a device by the device id Input: {"id":value}
									[Route("Devices/GetAllDevicesByName")]
									[HttpPost]
									GetAllDevicesByName() get a device by the device name Input: {"name":value}
									[Route("Devices/GetAllDevicesFromDateToDate")]
									[HttpPost]
									GetAllDevicesFromDateToDate() get all devices in a time interval Inputs: {"fromDate":value,"tillDate":value} or {"fromDate":value}*in this case the tillDate=now **date is the the format yyyy-mm-dd
		
		
scripts in the scripts folder
css in the style folder

DAL (Data Access Layer)- 

context class (Master Entities)

Data Queries: access class to the DB 
	functions:GetDevicesByOwnerName(string ownerName) get all devices by owner name
		GetAllDevices() get all devices from the DB
		GenerateDeviceUniqueName(Device device) return the device uniqe name
		DaysSinceDeviceWasCreated(Device device) return the number of days since the device was created
		GetDeviceById(int id) get a device by the device id
		GetAllDevicesByName(string deviceName) get a device by the device name
		GetAllDevicesFromDateToDate(DateTime fromDate, DateTime tillDate) get all devices in a time interval
		GetNumberOfDevices()  number of devices in the DB

AteraAppTests:
Tests for DaysSinceDeviceWasCreatedTest and GenerateDeviceUniqueNameTest
		