using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    class Triangle : ShapeBase
    {

        // exist here
        //public double area;
        //public double hekef;

        public double _a, _b, _c, _h;

        public override void CalcArea()
        {
            _area = _c * _h / 2.0;
        }

        public override void CalcHekef()
        {
            _hekef = _a + _b + _c;
        }

        public override string ToString()
        {
            return $"Triangle: a : {_a} b : {_b} c : {_c} h : {_h} " + base.ToString();
        }
    }
}
