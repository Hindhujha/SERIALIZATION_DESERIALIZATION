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
            FileStream fileStream = new FileStream(@"D:\BridgeLabz\SERIALIZATION_DESERIALIZATION\SERIALIZATION_DESERIALIZATION\Demo.txt", FileMode.Create);
            BinaryFormatter format=new BinaryFormatter();
            format.Serialize(fileStream, sample);
        }

        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"D:\BridgeLabz\SERIALIZATION_DESERIALIZATION\SERIALIZATION_DESERIALIZATION\Demo.txt", FileMode.Open);
            BinaryFormatter formatter=new BinaryFormatter();
            Demo deserializeSample=(Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application Name {deserializeSample.ApplicationName}---------Application ID {deserializeSample.ApplicationID}");
            Console.ReadKey();
        }
    }

    [Serializable]
    internal class Demo
    {
        public string ApplicationName { get; set; } = "BINARY SERIALIZE";

        public int ApplicationID { get; set; } = 1001;
    }
}
