using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_v._35_2023
{
    internal class RedAndBlue
    {
        private float _red;
        public float Red
        {
            get { return _red; }
            set { _red = value; }
        }


        private float _blue;

        public float Blue
        {
            get { return _blue; }
            set { _blue = value; }
        }

        private float _myFloat;
        public float MyFloat
        {
            get => _myFloat;
            set => _myFloat = Math.Max(Math.Min(value, maxValue), minValue);

            [Range(0.0f, 1.0f)]
            public float MyFloat { get; set; }
    }

    }
}
