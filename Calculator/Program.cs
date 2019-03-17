using System.Globalization;
using System.Linq;
using Calculator.Logic;

namespace Calculator.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("Hello user");

			var calculator = new Logic.Calculator();

			ExpectedInput expectedInput = ExpectedInput.Operant;

			string[] operationSymbols = {"+", "-", "*", "/"};

			PrintMenu();


            while (true)
            {
                string usersInput = System.Console.ReadLine();

                if (string.Compare(usersInput, "Q", true, CultureInfo.InvariantCulture) == 0)
                {
                    System.Console.WriteLine("Goodbye!");

                    break;
                }

                if (expectedInput == ExpectedInput.Operant)
                {
                    if (!float.TryParse(usersInput, out float operand1))
                    {
                        System.Console.WriteLine("Entered number is not valid.  Please enter valid number");

                        System.Console.WriteLine("Press Q to exit");
                    }
                    else
                    {
                        expectedInput = ExpectedInput.Operation;

                        calculator.Operand1 = operand1;

                        System.Console.WriteLine("Enter operation type ");
                    }
                }
                else if (expectedInput == ExpectedInput.Operation)
                {
                    string userInputTrimmed = usersInput.Trim();

                    if (operationSymbols.Contains(userInputTrimmed))
                    {
                        int index = operationSymbols.ToList().IndexOf(userInputTrimmed);

                        calculator.OperationType = (OperationType)(index + 1);


                        expectedInput = ExpectedInput.Operant2;


                        System.Console.WriteLine("Enter second operant ");
                    }
                    else
                    {
                        System.Console.WriteLine("Entered operation type is not valid. Please enter valid operation");
                        System.Console.WriteLine("Press Q to exit");
                    }
                }
                else if (expectedInput == ExpectedInput.Operant2)
                {
                    if (!float.TryParse(usersInput, out float operand2))
                    {
                        System.Console.WriteLine("Entered number is not valid. Please enter valid number");
                    }
                    else
                    {
                        expectedInput = ExpectedInput.Result;

                        calculator.Operand2 = operand2;

                        float result = calculator.PerfomeAction();

                        calculator.Result = result;

                        string history = calculator.ShowHistory();

                        System.Console.WriteLine($"Result is: {history} = {result}");

                        System.Console.WriteLine("Press Enter to start over");

                    }
                }
                else if (expectedInput == ExpectedInput.Result)
                {
                    expectedInput = ExpectedInput.Operation;

                    calculator.Operand1 = calculator.Result;

                    System.Console.WriteLine(calculator.Result);

                    System.Console.WriteLine("Enter operation type ");
                }
            }
		}

		static void PrintMenu()
		{
			System.Console.WriteLine("Please, enter the first number");
			System.Console.WriteLine("Press Q to exit");
		}
	}
}