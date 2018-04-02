using System;
using Newtonsoft.Json.Linq;
using log4net.Config;
using log4net;

namespace json
{
    class B
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(jsonSerialization));
        public string empname { get; set; }
        public string empid { get; set; }
    }
    /// <summary>
    /// this class we are retrieving partucular members from json object.
    /// </summary>
    class retrieveData
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(jsonSerialization));
        static void Main(string[] args)
        {
            try
            {
                XmlConfigurator.Configure();
                string jsondata = @"{ 'empname':'Murali,'empid':1234}";
                var data = JObject.Parse(jsondata);
                Console.WriteLine(string.Concat("here emp details", data["empname"], " " + data["empid"]));
                Console.ReadLine();
            }
            catch(Exception e)
            {
                log.Error(e.Message);
            }
        }
    }
}
