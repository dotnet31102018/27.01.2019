using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    class Program
    {


        static void Main(string[] args)
        {
            // abstract - not allowed!!
            //ShapeBase shape = new ShapeBase();

            Triangle t = new Triangle
            {
                _a = 4.4,
                _b = 3.3,
                _c = 3.7,
                _h = 2.5
            };

            Circle c = new Circle
            {
                _r = 7.4
            };

            Console.WriteLine(t);

            Console.WriteLine(c);
            


        }


    }
}
