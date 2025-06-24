using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class HexaObserver : Observer
    {
        public HexaObserver(Subject subject) : base(subject) { }
        public override void Update(int state) => Console.WriteLine("Hex String: " + Convert.ToString(_subject.GetState(), 16).ToUpper());
    }
}
