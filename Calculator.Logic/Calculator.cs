using System;
using System.Text;

namespace Calculator.Logic
{
	public class Calculator
	{
		float _operand1 = 0;

		float _operand2 = 0;

        float _result = 0;

		readonly StringBuilder _stringBuilder = new StringBuilder();

		OperationType _operationType = OperationType.None;

		public float Operand1
		{
			get => _operand1;
			set
			{
				_operand1 = value;
                _stringBuilder.Append(" " + _operand1);
			}
		}

        public float Result
        {
            get => _result;
            set
            {
                _result = value;
            }
        }

		public float Operand2
		{
			get => _operand2;
			set
			{
				_operand2 = value;
				_stringBuilder.Append(_operand2);
			}
		}

		public OperationType OperationType
		{
			get => _operationType;
			set
			{
				_operationType = value;
                if (_operationType == OperationType.Sum)
                {
                    _stringBuilder.Append("+");
                } else if (_operationType == OperationType.Diff)
                {
                    _stringBuilder.Append("-");
                } else if (_operationType == OperationType.Prod)
                {
                    _stringBuilder.Append("*");
                } else if (_operationType == OperationType.Div)
                {
                    _stringBuilder.Append("/");
                }
                   
				
			}
		}

		public float PerfomeAction()
		{
			switch (this._operationType)
			{
				case OperationType.Sum:
					return _operand1 + _operand2;

				case OperationType.Diff:
					return _operand1 - _operand2;

				case OperationType.Prod:
					return _operand1 * _operand2;

				case OperationType.Div:
					return _operand1 / _operand2;

				default:
					throw new InvalidOperationException($"{this._operationType} operation not supported");
			}
		}

		public string ShowHistory()
		{
			return _stringBuilder.ToString();
		}
	}
}