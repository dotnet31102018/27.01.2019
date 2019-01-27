using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701Airplane
{
    class AirPlane
    {
        public string _model;

        public int _numberOfPassengers;

        public Pilot[] _pilots;

        public Engine[] _engines;

        public void Fly()
        {

        }


        public override string ToString()
        {
            string result = $"Airplane model : {_model} number of passengers : {_numberOfPassengers} \n";

            // the \n is line feed

            result = result + "Pilots:\n";

            for (int i = 0; i < _pilots.Length; i++)
            {
                result = result + _pilots[i].ToString() + "\n";
            }

            result = result + "Engines:\n";

            for (int i = 0; i < _engines.Length; i++)
            {
                result = result + _engines[i].ToString() + "\n";
            }

            return result;
        }
    }
}
