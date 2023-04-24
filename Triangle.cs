using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLibrary
{
    public class Triangle: IShape
    {
        private double _a, _b, _c;

        public Triangle (double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }
        public double GetArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRightTriangle()
        {
            return (_a * _a + _b * _b == _c * _c) || (_a * _a + _c * _c == _b * _b) || (_b * _b + _c * _c == _a * _a);
        }
    }
}
