using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject) : base(subject) { }
        public override void Update(int state)
        {
            Console.WriteLine("Binary String: " + Convert.ToString(_subject.GetState(), 2));
        }
    }
}
