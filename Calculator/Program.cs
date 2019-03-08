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

            float operand1;

            float? operand2;

            OperationType operationType = OperationType.None;

            ExpectedInput expectedInput = ExpectedInput.Operant;

            string history = string.Empty;

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
                        
                        history += operand1.ToString() + " ";

                        Console.WriteLine("Enter operation type ");
                    }

                } else if (expectedInput == ExpectedInput.Operation)
                {
                  

                    if (usersInput.Trim() == "+")
                    {
                        history += usersInput.ToString() + " ";

                        expectedInput = ExpectedInput.Operant2;

                        operationType = OperationType.Sum;

                        Console.WriteLine("Enter second operant ");

                    } else if (usersInput.Trim() == "-")
                    {

                        history += usersInput.ToString() + " ";

                        expectedInput = ExpectedInput.Operant2;

                        operationType = OperationType.Diff;

                        Console.WriteLine("Enter second operant ");


                    } else if (usersInput.Trim() == "*")
                    {
                        history += usersInput.ToString() + " ";

                        expectedInput = ExpectedInput.Operant2;

                        operationType = OperationType.Prod;

                        Console.WriteLine("Enter second operant ");

                    } else if (usersInput.Trim() == "/")
                    {
                        history += usersInput.ToString() + " ";

                        expectedInput = ExpectedInput.Operant2;

                        operationType = OperationType.Div;

                        Console.WriteLine("Enter second operant ");

                    } else
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

                    }


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
