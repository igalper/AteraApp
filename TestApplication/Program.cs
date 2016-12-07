using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataQueries = new DAL.DataQueries();

            foreach( Device d in dataQueries.GetAllDevices())
                Console.WriteLine(d.ToString());
        }
    }
}
