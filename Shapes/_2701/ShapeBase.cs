using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2701
{
    abstract class ShapeBase
    {
        public double _area = 0.0;
        public double _hekef = 0.0;

        public abstract void CalcHekef();
        public abstract void CalcArea();

        public override string ToString()
        {
            CalcHekef();
            CalcArea();
            return $"area: { _area} hekef: { _hekef}";
        }
    }
}
