using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using log4net.Config;
using log4net;

namespace json
{
    class data
    {       
        public string empname { get; set; }
        public string empid { get; set; }
    }
    /// <summary>
    /// in this method retrieve the data using DeserializeObject()
    /// </summary>
    class retrieve
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(jsonSerialization));
        static void Main(string[] args)
        {
            try
            {
                XmlConfigurator.Configure();
                string jsondata = @"{'empname':'mohan','empid':1231}";
                data details = JsonConvert.DeserializeObject<data>(jsondata);
                Console.WriteLine(string.Concat("emp details:", details.empname, " " + details.empid));
                Console.ReadLine();
            }
            catch(Exception e)
            {
                log.Error(e.Message);
            }
        }
    }
}
