using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701OOP
{
    class Car
    {
        public string model;
        public string brand;

        public void Drive()
        {
            Console.WriteLine($"Driving {model} {brand}");
        }

        public void GoFast()
        {
            Console.WriteLine($"Going too fast in {model} {brand}");
        }
    }
}
