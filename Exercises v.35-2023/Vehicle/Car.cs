using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }




        public Car() { }

        public Car(string model, double price, string color)
        {
            _model = model;
            _price = price;
            _color = color;
        }

        public void HalfPrice(Car car)
        {
            _price = car.Price/2 ;
            Console.WriteLine(car.Price);
        }
    }
}
