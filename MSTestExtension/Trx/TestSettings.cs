using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class TestSettings
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("id")]
        public Guid Id { get; set; }

        public TestSettings_Deployment Deployment { get; set; }

        public TestSettings_Execution Execution { get; set; }

        public TestSettings_Properties Properties { get; set; }
    }
}
