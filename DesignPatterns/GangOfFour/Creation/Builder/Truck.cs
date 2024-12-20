using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Builder
{
    public class Truck : IBuilder
    {
        private string _brand;
        private Product _product;

        public Truck(string brand)
        {
            _brand = brand;
            _product = new Product();
        }

        public void AddLights()
        {
            _product.Add("Truck Lights");
        }

        public void AddWheels()
        {
            _product.Add("Truck Wheels");
        }

        public void BuildBody()
        {
            _product.Add("Truck Body");
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
            _product.Add(string.Format("Truck Brand Name: {0}", _brand));
        }
    }
}
