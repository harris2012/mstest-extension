using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class Times
    {
        [XmlAttribute("creation")]
        public DateTime Creation { get; set; }

        [XmlAttribute("queuing")]
        public DateTime Queuing { get; set; }

        [XmlAttribute("start")]
        public DateTime Start { get; set; }

        [XmlAttribute("finish")]
        public DateTime Finish { get; set; }
    }
}
