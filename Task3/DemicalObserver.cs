using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class DemicalObserver : Observer
    {
        public DemicalObserver(Subject subject) : base(subject) { }
        public override void Update(int state) => Console.WriteLine("Demical String: " + Convert.ToString(_subject.GetState(), 10).ToUpper());
    }
}
