using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class Tests
    {
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 5, ExpectedResult = 10)]
        [TestCase(-5, -5, ExpectedResult = -10)]
        [TestCase(-5, 5, ExpectedResult = 0)]
        public double TestSum(double operand1, double operand2)
        {
            return Calculator.Calculate(operand1, operand2, OperationType.Sum);
        }


        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(15, 5, ExpectedResult = 10)]
        [TestCase(-5, -5, ExpectedResult = 0)]
        [TestCase(-5, 5, ExpectedResult = -10)]
        public double TestSubtraction(double operand1, double operand2)
        {
            return Calculator.Calculate(operand1, operand2, OperationType.Subtraction);
        }


        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(5, 5, ExpectedResult = 25)]
        [TestCase(-5, -5, ExpectedResult = 25)]
        [TestCase(-5, 5, ExpectedResult = -25)]
        public double TestMultiple(double operand1, double operand2)
        {
            return Calculator.Calculate(operand1, operand2, OperationType.Multiple);
        }


        [TestCase(5, 5, ExpectedResult = 1)]
        [TestCase(-5, -5, ExpectedResult = 1)]
        [TestCase(-5, 5, ExpectedResult = -1)]
        public double TestDivide(double operand1, double operand2)
        {
            return Calculator.Calculate(operand1, operand2, OperationType.Divide);
        }


        [Test]
        public void TestDivideByZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => Calculator.Calculate(1, 0, OperationType.Divide));
        }


        [Test]
        public void TestArgumentException()
        {
            Assert.Throws<ArgumentException>(
                () => Calculator.Calculate(1, 0, OperationType.Sqrt));
        }
    }
}