using MSTestExtension.Trx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension
{
    public static class TrxReader
    {
        public static TestRun Read(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TestRun));

                return (TestRun)serializer.Deserialize(stream);
            }
        }
    }
}
