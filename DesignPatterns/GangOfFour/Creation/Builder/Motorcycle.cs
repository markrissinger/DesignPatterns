using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creation.Builder
{
    public class Motorcycle : IBuilder
    {
        private string _brand;
        private Product _product;

        public Motorcycle(string brand)
        {
            _brand = brand;
            _product = new Product();
        }

        public void AddLights()
        {
            _product.Add("Motorcycle Lights");
        }

        public void AddWheels()
        {
            _product.Add("Motorcycle Wheels");
        }

        public void BuildBody()
        {
            _product.Add("Motorcycle Body");
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
            _product.Add(string.Format("Motorcycle Brand Name: {0}", _brand));
        }
    }
}