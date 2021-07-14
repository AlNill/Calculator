using System;

namespace Calculator
{
    public enum OperationType
    {
        Sum,
        Subtraction,
        Divide,
        Multiple
    }


    public static class Calculator
    {
        public static double Calculate(double operand1, double operand2, OperationType operation)
        {
            return operation switch
            {
                OperationType.Sum => operand1 + operand2,
                OperationType.Subtraction => operand1 - operand2,
                OperationType.Multiple => operand1 * operand2,
                OperationType.Divide => operand2 != 0
                    ? operand1 / operand2
                    : throw new DivideByZeroException("Divider must be not zero"),
                _ => throw new ArgumentException("Bad operation type!")
            };
        }
    }
}
