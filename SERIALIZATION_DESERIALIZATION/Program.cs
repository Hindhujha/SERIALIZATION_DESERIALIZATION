﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace SERIALIZATION_DESERIALIZATION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SERIALIZATION_DESERIALIZATION PROGRAMS");
            Serialize_Deserialize obj = new Serialize_Deserialize();
           //  obj.Serialization();
             //obj.DeSerialization();
            JSON json = new JSON();
            json.JSON_Serialize();
            json.JSON_DeSerialize();
            Xml xml = new Xml();
            xml.XML_Serialize();
        }

    }
}
