using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SERIALIZATION_DESERIALIZATION
{
    internal class Serialize_Deserialize
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"D:\Example.txt", FileMode.Create);
            BinaryFormatter format=new BinaryFormatter();
            format.Serialize(fileStream, sample);
        }
    }

    internal class Demo
    {
        public string ApplicationName { get; set; } = "BINARY SERIALIZE";

        public int ApplicationID { get; set; } = 1001;
    }
}
