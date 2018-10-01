using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteAndReadFromFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variable and call methods
            var readAndWrite = new PerformFunctions();
            readAndWrite.readFromFile();
            readAndWrite.getOperand();
            readAndWrite.getTotal();
            readAndWrite.writeResultsToFile();

           
        }
    }
}
