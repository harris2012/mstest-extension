using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class UnitTest_Execution
    {
        [XmlAttribute("id")]
        public Guid Id { get; set; }
    }
}
