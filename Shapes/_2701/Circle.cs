using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    class Circle : ShapeBase
    {

        // exist here
        //public double area;
        //public double hekef;

        public double _r;

        public override void CalcArea()
        {
            _area = _r * _r * Math.PI;
        }

        public override void CalcHekef()
        {
            _hekef = 2 * _r * Math.PI;
        }

        public override string ToString()
        {
            return $"Triangle: r : {_r} " + base.ToString();
        }
    }
}
