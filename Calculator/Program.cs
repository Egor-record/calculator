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


            while (true)
            {
                PrintMenu();

                string usersInput = Console.ReadLine();

                if (string.Compare( usersInput, "Q", true) == 0)
                {
                    break;
                }

                if (expectedInput == ExpectedInput.Operant)
                {

                    if (!float.TryParse(usersInput, out operand1))
                    {

                        Console.WriteLine("Entered number is not valid");

                    }
                    else
                    {
                        expectedInput = ExpectedInput.Operation;
                        
                        history += operand1.ToString() + " ";

                        Console.WriteLine("Enter operation type ");
                    }
                } else if (expectedInput == ExpectedInput.Operation)
                {

                    // TODO: По аналогии распарсить что введт поль, если плюс, то продолжить, если не плюс то вывести сообщение об ошибки и добиться чтобы в вел нормальный знак
                    // TODO: Второе число после того как польщователь ввел плюс или минус 
                    // TODO: Чтобы ввыводился результат и хистори, где все это сохраняется

                }

                


                Console.WriteLine("This is history: " + history);
            }


        }

        static void PrintMenu()
        {
            Console.WriteLine("Please, enter the first number");
            Console.WriteLine("Press Q to exit");
            Console.WriteLine("Press + to perfome sum");


        }
    }
}
