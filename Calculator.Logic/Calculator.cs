using System;
using System.Text;

namespace Calculator.Logic
{
    public class Calculator
    {
        float operand1 = 0;

        float operand2 = 0;

        StringBuilder stringBuilder = new StringBuilder();

        OperationType operationType = OperationType.None;

        public float Operand1 {
            get => operand1;
            set {
                operand1 = value;
                stringBuilder.Append(operand1);
            }
        }
        public float Operand2 {
            get => operand2;
            set {
                operand2 = value;
                stringBuilder.Append(operand2);
            }
        }

        public OperationType OperationType
        {
            get => operationType;
            set {

                operationType = value;
                stringBuilder.Append(operationType);
            }
        }

        public float PerfomeAction()
        {
            switch (this.operationType)
            {
                case OperationType.Sum:
                    return operand1 + operand2;

                case OperationType.Diff:
                    return operand1 - operand2;

                case OperationType.Prod:
                    return operand1 * operand2;

                case OperationType.Div:
                    return operand1 / operand2;

                default:
                    throw new InvalidOperationException($"{ this.operationType } operation not supported");
            }
        }

        public string ShowHistory()
        {
            return stringBuilder.ToString();
        }
    }
}
