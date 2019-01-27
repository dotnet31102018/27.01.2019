using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701Airplane
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5 };
            AirPlane myAirPlane = new AirPlane
            {
                _model = "747",
                _numberOfPassengers = 320,
                _engines = new Engine[] 
                {
                    new Engine { _power = 5.5, _voltage = 8.1f },
                    new Engine { _power = 8.3, _voltage = 5.3f },
                    new Engine { _power = 1.9, _voltage = 0.8f }
                },
                _pilots = new Pilot[]
                {
                    new Pilot { age = 40, gender = "Female", name = "Dana" },
                    new Pilot { age = 45, gender = "Male", name = "Moshe" }
                }
            };

            // long way
            myAirPlane._engines = new Engine[3];
            myAirPlane._engines[0] = new Engine { _power = 5.5, _voltage = 8.1f };
            myAirPlane._engines[1] = new Engine { _power = 8.3, _voltage = 5.3f };
            myAirPlane._engines[2] = new Engine { _power = 1.9, _voltage = 0.8f };
            // long way
            myAirPlane._pilots = new Pilot[2];
            myAirPlane._pilots[0] = new Pilot { age = 40, gender = "Female", name = "Dana" };
            myAirPlane._pilots[1] = new Pilot { age = 45, gender = "Male", name = "Moshe" };

            Console.WriteLine(myAirPlane);
        }
    }
}
