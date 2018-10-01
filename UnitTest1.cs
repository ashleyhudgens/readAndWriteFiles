using System;
using WriteAndReadFromFiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            var addTest = new PerformFunctions();
            addTest.typeOfArithmetic = "add";
            addTest.firstOperand = 5;
            addTest.secondOperand = 2;
            addTest.getTotal();
            Assert.AreEqual(addTest.total, 7);
        }
        [TestMethod]

        public void TestMethodSubtract()
        {
            var subtractTest = new PerformFunctions();
            subtractTest.typeOfArithmetic = "subtract";
            subtractTest.firstOperand = 5;
            subtractTest.secondOperand = 2;
            subtractTest.getTotal();
            Assert.AreEqual(subtractTest.total, 3);
        }
        [TestMethod]

        public void TestMethodMultiply()
        {
            var multiplyTest = new PerformFunctions();
            multiplyTest.typeOfArithmetic = "multiply";
            multiplyTest.firstOperand = 5;
            multiplyTest.secondOperand = 2;
            multiplyTest.getTotal();
            Assert.AreEqual(multiplyTest.total, 10);
        }
        [TestMethod]

        public void TestMethodDivide()
        {
            var divideTest = new PerformFunctions();
            divideTest.typeOfArithmetic = "divide";
            divideTest.firstOperand = 25;
            divideTest.secondOperand = 5;
            divideTest.getTotal();
            Assert.AreEqual(divideTest.total, 5);
        }

        [TestMethod]

        public void TestMethodGetOperatorAdd()
        {
            var operatorTest = new PerformFunctions();
            operatorTest.typeOfArithmetic = "add";
            operatorTest.getOperand();
            Assert.AreEqual(operatorTest.operand, "+");
        }

        [TestMethod]

        public void TestMethodGetOperatorSubtract()
        {
            var operatorTest = new PerformFunctions();
            operatorTest.typeOfArithmetic = "subtract";
            operatorTest.getOperand();
            Assert.AreEqual(operatorTest.operand, "-");
        }

        [TestMethod]

        public void TestMethodGetOperatorMultiply()
        {
            var operatorTest = new PerformFunctions();
            operatorTest.typeOfArithmetic = "multiply";
            operatorTest.getOperand();
            Assert.AreEqual(operatorTest.operand, "*");
        }

        [TestMethod]

        public void TestMethodGetOperatorDivide()
        {
            var operatorTest = new PerformFunctions();
            operatorTest.typeOfArithmetic = "divide";
            operatorTest.getOperand();
            Assert.AreEqual(operatorTest.operand, "/");
        }
    }
}
