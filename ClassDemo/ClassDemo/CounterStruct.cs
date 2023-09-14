using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal struct CounterStruct
    {
        public int Counter { get; private set; }

        public CounterStruct()
        {
            Counter = 10;
        }

        public void CountUp()
        {
            Counter++;
        }
        public void CountDown()
        {
            Counter--;
        }
    }
}
