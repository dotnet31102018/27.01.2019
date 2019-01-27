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

        public override void CalcHekef()
        {
            _hekef = _a + _b + _c;
        }
    }
}
