using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Json.Net;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace SERIALIZATION_DESERIALIZATION
{
    public class JSON
    {
        public void JSON_Serialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "HINDHUJHA",
                Description = "C SHARP PROGRAMMING"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
        }
    }

     [DataContract]
    class BlogSites
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

    }
}
