using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MSTestExtension.Trx;

namespace MSTestExtension.Trx
{

    [XmlRoot(Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public class TestRun
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("runUser")]
        public string RunUser { get; set; }

        public TestSettings TestSettings { get; set; }

        public Times Times { get; set; }

        public ResultSummary ResultSummary { get; set; }

        [XmlArray]
        public List<UnitTest> TestDefinitions { get; set; }

        [XmlArray]
        public List<TestList> TestLists { get; set; }

        [XmlArray]
        public List<TestEntry> TestEntries { get; set; }

        [XmlArray]
        public List<UnitTestResult> Results { get; set; }

    }
}
