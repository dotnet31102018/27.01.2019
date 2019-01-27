using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2701
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer pc = new Computer
            {
                _isTurnOn = true,
                _model = "DELL",
                _numberOfProcessors = 16,
                _price = 8599,
                _screenSize = 17.1f
            };

            Computer mac = new Computer
            {
                _isTurnOn = true,
                _model = "MAC BOOK PRO",
                _numberOfProcessors = 8,
                _price = 12778,
                _screenSize = 15.3f
            };

            mac.TurnOff();

            Console.WriteLine(mac);
        }
    }
}
