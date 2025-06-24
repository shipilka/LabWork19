using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork19
{
    class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy) => _strategy = strategy;

        public int ExecuteStrategy(int num1, int num2) => _strategy.DoOperation(num1, num2);
    }
}
