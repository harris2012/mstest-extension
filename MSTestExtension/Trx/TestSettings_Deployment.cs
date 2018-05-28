using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class TestSettings_Deployment
    {
        [XmlAttribute("userDeploymentRoot")]
        public string UserDeploymentRoot { get; set; }

        [XmlAttribute("useDefaultDeploymentRoot")]
        public bool UseDefaultDeploymentRoot { get; set; }

        [XmlAttribute("runDeploymentRoot")]
        public string RunDeploymentRoot { get; set; }
    }
}
