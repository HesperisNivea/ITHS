using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_v._35_2023
{
    internal class Counter
    {
        public int Count { get; private set; } = 1000;

        public Counter() { }

        public void CountUp()
        {
            Count++;
        }

        public void Reset()
        {
            Count = 0;
        }

    }



}
