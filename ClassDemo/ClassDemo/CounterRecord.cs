using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal record CounterRecord
    {
        public int Counter { get; private set; }

        public CounterRecord()
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
