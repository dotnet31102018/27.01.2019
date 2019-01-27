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

            PrintCircleArea(c);

            PrintTriangle(t);

            PrintAreaOfShape(c);
            PrintAreaOfShape(t);

            TriangleRightAngle t3 = new TriangleRightAngle();
            PrintTriangle(t3);

        }

        static void PrintCircleArea(Circle c2)
        {
            c2.CalcArea();
            Console.WriteLine( c2._area );
        }

        static void PrintTriangle(Triangle t2)
        {
            t2.CalcArea();
            Console.WriteLine(t2._area);
        }

        static void PrintAreaOfShape(ShapeBase s2)
        {
            s2.CalcArea();
            Console.WriteLine(s2._area);
        }

    }
}
