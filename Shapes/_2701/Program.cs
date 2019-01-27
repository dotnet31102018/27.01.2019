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

            int[] arr = { 1, 3, 4 };
            int[] arr2 = new int[3];
            arr2[0] = 1;
            arr2[1] = 5;
            arr2[2] = 3;

            Circle[] circlesArray = { new Circle { _r = 2.2 } , new Circle { _r = 5.7 } };
            Circle[] circles = new Circle[3];
            circles[0] = new Circle
            {
                _r = 7.4
            };

            ShapeBase[] shapesArray = { new Circle(), new Triangle() };

            ShapeBase[][] shapesJag = new ShapeBase[5][];


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
