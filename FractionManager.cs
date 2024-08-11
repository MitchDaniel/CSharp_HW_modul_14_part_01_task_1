using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CSharp_HW_modul_14_part_01
{
    internal static class FractionManager
    {
        public static void XmlSerialize(FractionCollection fractionCollection)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(FractionCollection));
            using FileStream fs = new FileStream(@"C:\Users\Brill\Desktop\FractionCollections.xml", FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fs, fractionCollection);
        }

        public static void XmlDeserialize()
        { }
    }
}


//XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

//// получаем поток, куда будем записывать сериализованный объект
//using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
//{
//    xmlSerializer.Serialize(fs, person);

//    Console.WriteLine("Object has been serialized");
//}