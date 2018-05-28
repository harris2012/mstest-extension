using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class UnitTest
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("storage")]
        public string Storage { get; set; }

        [XmlAttribute("id")]
        public Guid Id { get; set; }

        public UnitTest_Execution Execution { get; set; }

        public UnitTest_TestMethod TestMethod { get; set; }

    }
}
