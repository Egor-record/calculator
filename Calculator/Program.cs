using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user");

            //Calculator calculator = new Calculator();

            ExpectedInput expectedInput = ExpectedInput.Operant;

            string[] operationSymbols = { "+", "-", "*", "/" };

            float result = 0;



            PrintMenu();


            while (true)
            {
               

                string usersInput = Console.ReadLine();

                if (string.Compare( usersInput, "Q", true) == 0)
                {
                    Console.WriteLine("Goodbye!");

                    break;
                }

                if (expectedInput == ExpectedInput.Operant)
                {

                    if (!float.TryParse(usersInput, out operand1))
                    {

                        Console.WriteLine("Entered number is not valid");

                        Console.WriteLine("Press Q to exit");

                    }
                    else
                    {
                        expectedInput = ExpectedInput.Operation;

                        calculator.Operand1 = operand1;

                        Console.WriteLine("Enter operation type ");

                    }

                 

                } else if (expectedInput == ExpectedInput.Operation)
                {

                    string userInputTrimmed = usersInput.Trim();

                    if (operationSymbols.Contains(userInputTrimmed))
                    {

                        //operationType = Enum.Parse(typeof(OperationType), )

                        int index = operationSymbols.ToList().IndexOf(userInputTrimmed);

                        operationType = (OperationType)(index + 1);

                        calculator.operationType = operationType;


                        expectedInput = ExpectedInput.Operant2;

                    

                        Console.WriteLine("Enter second operant ");

                    }  else
                    {
                        Console.WriteLine("Entered operation type is not valid");
                        Console.WriteLine("Press Q to exit");
                    }

                    // TODO: По аналогии распарсить что введт поль, если плюс, то продолжить, если не плюс то вывести сообщение об ошибки и добиться чтобы в вел нормальный знак
                    // TODO: Второе число после того как польщователь ввел плюс или минус 
                    // TODO: Чтобы ввыводился результат и хистори, где все это сохраняется

                } else if (expectedInput == ExpectedInput.Operant2)
                {

                    if (!float.TryParse(usersInput, out operand2))
                    {

                        Console.WriteLine("Entered number is not valid");

                        

                    }
                    else
                    {
                        expectedInput = ExpectedInput.Result;

                        calculator.Operand2 = operand2;

                        calculator.PerfomeAction();
                    }


                }  else if (expectedInput == ExpectedInput.Result)
                {
                   


                }




                 //   Console.WriteLine("This is history: " + history);
            }


        }

        static void PrintMenu()
        {
            Console.WriteLine("Please, enter the first number");
            Console.WriteLine("Press Q to exit");
        }
    }
}
