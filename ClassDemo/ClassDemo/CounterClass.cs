using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class CounterClass
    {
        public int Counter { get; private set; }

        public CounterClass()
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

        public override bool Equals(object? obj)
        {
            if (obj is CounterClass counterClass) // prownuje klasse do klassy 
            {
                if (counterClass.Counter == Counter)
                {
                    return true;
                }

            }
            return false;

        }
    }
}
