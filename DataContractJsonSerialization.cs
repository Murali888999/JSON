using System;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace json
{
    [DataContract]
    public class A
    {
        [DataMember]
        public string firstname { get; set; }
        [DataMember]
        public string lastname { get; set; }
    }
    class DataContract
    {
        static void Main(string[] args)
        {
            string data = "{ \"firstname\":\"murali\",\"lastname\":\"mohan\"}";
            
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(A));
            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(data));
            stream.Position = 0;
            A dataContractDetail = (A)jsonSerializer.ReadObject(stream);
            Console.WriteLine(string.Concat("hello...... ", dataContractDetail.firstname, " " + dataContractDetail.lastname));
            Console.ReadKey();

        }
    }
}
