using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSTestExtension.Trx
{
    public class ResultSummary_Counters
    {
        [XmlAttribute("total")]
        public int Total { get; set; }

        [XmlAttribute("executed")]
        public int Executed { get; set; }

        [XmlAttribute("passed")]
        public int Passed { get; set; }

        [XmlAttribute("error")]
        public int Error { get; set; }

        [XmlAttribute("failed")]
        public int Failed { get; set; }

        [XmlAttribute("timeout")]
        public int Timeout { get; set; }

        [XmlAttribute("aborted")]
        public int Aborted { get; set; }

        [XmlAttribute("inconclusive")]
        public int Inconclusive { get; set; }

        [XmlAttribute("passedButRunAborted")]
        public int passedButRunAborted { get; set; }

        [XmlAttribute("notRunnable")]
        public int notRunnable { get; set; }

        [XmlAttribute("notExecuted")]
        public int notExecuted { get; set; }

        [XmlAttribute("disconnected")]
        public int disconnected { get; set; }

        [XmlAttribute("warning")]
        public int warning { get; set; }

        [XmlAttribute("completed")]
        public int completed { get; set; }

        [XmlAttribute("inProgress")]
        public int inProgress { get; set; }

        [XmlAttribute("pending")]
        public int pending { get; set; }

    }
}
