using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    class TriangleEqualSides : Triangle
    {
        public override void CalcHekef()
        {
            _hekef = _a * 2 + _c;
        }

        public override string ToString()
        {
            return $"Triangle Equal Sides " + base.ToString();
        }
    }
}
