using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task10
{
    internal class Car
    {
        private string brandCar;

        public string BrandCar
        {
            get => brandCar;
            set { brandCar = value; }
        }

        public Car(string _brandCar = "LADA")
        {
            brandCar = _brandCar;
        }
    }
}