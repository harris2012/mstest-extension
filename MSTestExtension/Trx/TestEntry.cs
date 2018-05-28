using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class TestEntry
    {
        [XmlAttribute("testId")]
        public Guid TestId { get; set; }

        [XmlAttribute("executionId")]
        public Guid ExecutionId { get; set; }

        [XmlAttribute("testListId")]
        public Guid TestListId { get; set; }
    }
}
