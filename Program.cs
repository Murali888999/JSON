using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using log4net;
using log4net.Config;

namespace json
{
    class details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(jsonSerialization));
        /// <summary>
        /// in this method printing json object
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            try
            {
                string data = "{\"FirstName\":\"Murali\",\"LastName\":\"Mohan\"}";
                dynamic ddata = JObject.Parse(data);

                Console.WriteLine(string.Concat("Hello ", ddata.FirstName, " " + ddata.LastName));
                Console.ReadKey();
            }
            catch(Exception e)
            {
                log.Error(e.Message);
            }

        }
    }
}
