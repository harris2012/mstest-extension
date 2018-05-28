using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class TestSettings_Execution
    {
        public TestSettings_Execution_TestTypeSpecific TestTypeSpecific { get; set; }

        public TestSettings_Execution_AgentRule AgentRule { get; set; }
    }
}
