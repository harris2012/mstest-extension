using MSTestExtension.Trx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MSTestExtension
{
    public class TrxWriter
    {
        public static void Write(string path, TestRun testRun)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, "http://microsoft.com/schemas/VisualStudio/TeamTest/2010");

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(TestRun), string.Empty);

                    serializer.Serialize(writer, testRun, ns);
                }
            }
        }
    }
}
