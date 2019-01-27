using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    class TriangleRightAngle : Triangle
    {
        public override void CalcArea()
        {
            _area = _a * _b / 2.0;
        }

        public override string ToString()
        {
            return $"Triangle Right Angle " + base.ToString();
        }
    }
}
