using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Builder
{
    public class Car : IBuilder
    {
        private string _brand;
        private Product _product;

        public Car(string brand)
        {
            _brand = brand;
            _product = new Product();
        }

        public void AddLights()
        {
            _product.Add("Car Lights");
        }

        public void AddWheels()
        {
            _product.Add("Car Wheels");
        }

        public void BuildBody()
        {
            _product.Add("Car Body");
        }

        public void End()
        {
        }

        public Product GetVehicle()
        {
            return _product;
        }

        public void Start()
        {
            _product.Add(string.Format("Car Brand Name: {0}", _brand));
        }
    }
}
