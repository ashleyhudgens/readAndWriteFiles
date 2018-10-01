using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteAndReadFromFiles
{
    interface ISetup
    {
        void readFromFile();
        string typeOfArithmetic { get; set; }
        double firstOperand { get; set; }
        double secondOperand { get; set; }
        string getOperand();
        string operand { get; set; }
        double getTotal();
        double total { get; set; }
        void writeResultsToFile();


    }
}
