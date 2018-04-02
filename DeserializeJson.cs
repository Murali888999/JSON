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
    class DeserializeJson
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(DeserializeJson));
        static void Main(string[] args)
        {
            deserialize();
            Console.ReadLine();
        }
        /// <summary>
        /// this is the method for deserialization using DeserializeObject
        /// </summary>
        static void deserialize()
        {
            try
            {
                XmlConfigurator.Configure();
                string s = @"{'id':121,'name':'murali','age':23}";
                data1 obj = JsonConvert.DeserializeObject<data1>(s);
                Console.WriteLine("id:" + obj.id);
                Console.WriteLine("name:" + obj.name);
                Console.WriteLine("age:" + obj.age);
            }
            catch(Exception e)
            {
                log.Error(e.Message);
            }
        }
    }
}
