using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class UnitTestResult
    {
        [XmlAttribute("executionId")]
        public Guid ExecutionId { get; set; }

        [XmlAttribute("testId")]
        public Guid TestId { get; set; }

        [XmlAttribute("testName")]
        public string TestName { get; set; }

        [XmlAttribute("computerName")]
        public string ComputerName { get; set; }

        [XmlIgnore]
        public TimeSpan Duration { get; set; }

        [XmlAttribute("duration")]
        public string DurationValue { get { return Duration.ToString(); } set { Duration = TimeSpan.Parse(value); } }

        [XmlAttribute("startTime")]
        public DateTime StartTime { get; set; }

        [XmlAttribute("endTime")]
        public DateTime EndTime { get; set; }

        [XmlAttribute("testType")]
        public Guid TestType { get; set; }

        [XmlAttribute("outcome")]
        public string Outcome { get; set; }

        [XmlAttribute("testListId")]
        public Guid TestListId { get; set; }

        [XmlAttribute("relativeResultsDirectory")]
        public Guid RelativeResultsDirectory { get; set; }

        public UnitTestResult_Output Output { get; set; }
    }
}
