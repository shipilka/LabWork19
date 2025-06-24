using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class OctalObserver : Observer
    {
        public OctalObserver(Subject subject) : base(subject) { }
        public override void Update(int state)
        {
            Console.WriteLine("Octal String: " + Convert.ToString(_subject.GetState(), 8));
        }
    }
}
