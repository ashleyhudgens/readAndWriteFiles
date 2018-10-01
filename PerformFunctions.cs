using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteAndReadFromFiles
{
   public class PerformFunctions : ISetup
    {
        //set up variables from interface
        public string typeOfArithmetic { get; set; }
        public double firstOperand { get; set; }
        public double secondOperand { get; set; }
        public double total { get; set; }
        public string operand { get; set; }

        //read type of arithmetic, first operand and second operand from file - file is in csv format EX: add,1,2 ***will need to change file location on non local computer***
        public void readFromFile()
        {
            StreamReader reader = new StreamReader("C:\\Users\\ahudgens\\desktop\\testingfiles.txt");
            using (reader)
            {
                string read = reader.ReadLine();
                string[] variables = read.Split(',');
                typeOfArithmetic = variables[0];
                firstOperand = Convert.ToDouble(variables[1]);
                secondOperand = Convert.ToDouble(variables[2]);
            }

        }

        //get type of operand to print out to file
        public String getOperand()
        {
            if (typeOfArithmetic == "add")
            {
                operand = "+";
                return operand;
            }
            else if (typeOfArithmetic == "subtract")
            {
                operand = "-";
                return operand;
            }
            else if (typeOfArithmetic == "multiply")
            {
                operand = "*";
                return operand;
            }
            else if (typeOfArithmetic == "divide")
            {
                operand = "/";
                return operand;
            }
            else
            {
                return operand;
            }
        }

        //get total to print out to file
        public double getTotal()
        {
            if (typeOfArithmetic == "add")
            {
                total = firstOperand + secondOperand;
                return total;
            } else if (typeOfArithmetic == "subtract")
            {
                total = firstOperand - secondOperand;
                return total;
            } else if (typeOfArithmetic == "multiply")
            {
                total = firstOperand * secondOperand;
                return total;
            } else if (typeOfArithmetic == "divide")
            {
                total = firstOperand / secondOperand;
                return total;
            } else
            {
                return total;
            }

        }

        //write results out to file ***Will need to change path on non local computer***
        public void writeResultsToFile()
        {
            Console.Write(operand);
            StreamWriter write = new StreamWriter("C:\\Users\\ahudgens\\desktop\\results.txt");
            using (write)
            {
                write.WriteLine("The total of " + firstOperand + operand + secondOperand + " is " + total);
            }

        }

    }
}
