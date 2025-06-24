using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Observer
    {
        protected Subject _subject;
        public Observer(Subject subject)
        {
            _subject = subject;
            _subject.StateChanged += Update;
        }
        public virtual void Update(int state) { }

    }
}
