using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork19
{
    class OperationSubstract : IStrategy
    {
        public int DoOperation(int num1, int num2) => num1 - num2;
    }
}
