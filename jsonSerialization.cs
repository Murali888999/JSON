using System;
using Newtonsoft.Json;
using log4net.Config;
using log4net;

namespace json
{
    class data1
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
    class jsonSerialization
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(jsonSerialization));
        static void Main(string[] args)
        {
            serialize();
        }
        /// <summary>
        /// serialize() method for serialize the json object
        /// </summary>
     static void serialize()
        {
            try
            {
                data1 t = new data1
                {
                    id = 121,
                    name = "Murali",
                    age = 23
                };

                string serialization = JsonConvert.SerializeObject(t);
                Console.WriteLine(serialization);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
        }
    }
}