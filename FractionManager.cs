using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CSharp_HW_modul_14_part_01
{
    public static class FractionManager
    {
        public static void XmlSerialize(FractionCollection fractionCollection, string path)
        {
            if(path is null) throw new ArgumentNullException("path");
            if (fractionCollection is null) throw new ArgumentNullException();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(FractionCollection));
            using FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fs, fractionCollection);
        }

        public static FractionCollection XmlDeserialize(string path)
        {
            if (path is null) throw new ArgumentNullException();
            if(!File.Exists(path)) throw new FileNotFoundException();
            XmlSerializer formatter = new XmlSerializer(typeof(FractionCollection));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            return formatter.Deserialize(fs) as FractionCollection ?? throw new XmlException();
        }
    }
}
