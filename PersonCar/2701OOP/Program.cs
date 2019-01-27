using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person
            {
                id = 1,
                name = "Danny",
                myCar = new Car
                {
                    brand = "Ferrari",
                    model = "Testa Rosa"
                }
            };

            
            Car c = new Car
            {
                brand = "Ferrari",
                model = "Testa Rosa"
            };

            Person p = new Person
            {
                id = 1,
                name = "Moshe",
                myCar = c
            };

            Person p2 = new Person
            {
                id = 1,
                name = "David",
                myCar = p.myCar
            };


        }
    }
}
