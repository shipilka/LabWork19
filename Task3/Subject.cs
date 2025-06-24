using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Subject
    {
        private int _state;
        public event Action<int>? StateChanged;

        public int GetState() => _state;

        public void SetState(int state)
        {
            _state = state;
            StateChanged?.Invoke(_state);
        }
    }
}
