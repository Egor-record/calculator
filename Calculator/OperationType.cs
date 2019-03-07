using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum OperationType
    {
        None = 0,
        Sum = 1,
        Diff = 2,
        Prod = 3,
        Div = 4

    }

    enum ExpectedInput
    {
        None = 0,
        Operant = 1,
        Operation = 2,
        Operant2 = 3
    }
}
