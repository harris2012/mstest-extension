using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class TestSettings_Execution_AgentRule
    {
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
