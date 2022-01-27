using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SERIALIZATION_DESERIALIZATION
{
    public class Xml
    {
        public void XML_Serialize()
        {
            XmlSerializer serial = new XmlSerializer(typeof(orderForm));
            FileStream filestream = new FileStream(@"D:\BridgeLabz\SERIALIZATION_DESERIALIZATION\SERIALIZATION_DESERIALIZATION\xmlDemo.txt", FileMode.Create);
            orderForm order = new orderForm();
            DateTime time = new DateTime(2022, 01, 06);
            order.OrderDate = time;
            serial.Serialize(filestream, order);

        }
    }

    public class orderForm
    {
        public DateTime OrderDate;
    }
}
