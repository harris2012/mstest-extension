using MSTestExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestExtension.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = "TestTrxFile.trx.txt";
            var target = "TestTrxFile_output.trx.txt";

            var testRun = TrxReader.Read(source);

            TrxWriter.Write(target, testRun);
        }
    }
}
