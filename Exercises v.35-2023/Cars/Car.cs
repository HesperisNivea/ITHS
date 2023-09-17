using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        private string _model;
        private double _price;
        private string _color;

        public int Price { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public Car() { }

        public Car(string model, double price, string color)
        {
            _model = model;
            _price = price;
            _color = color;
        }

        public void HalfPrice()
        {
            Price = Price/2;
        }
    }
}
