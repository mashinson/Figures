using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class RegularTriangle : RegularPolygon
    {
        public RegularTriangle() : base("Regular Triangle") { }
        public RegularTriangle(string name = "Regular Triangle") : base(name) { }
        public RegularTriangle(Point[] p) : base("Regular Triangle")
        {
            _vertices = new Point[3];
            for (int i = 0; i < _vertices.Length; i++)
            {
                _vertices[i] = p[i];
            }
        }

        public override double Area
        {
            get
            {
                double side = 0;
                double ar = 0;
                side = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));
                ar = (3 * Math.Sqrt(3) * side * side) / 2;

                return Math.Round(ar, 1);
            }

        }

        public override double Perimeter
        {
            get
            {
                double side = 0;
                side = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));

                return Math.Round(side *3, 1);
            }
        }
    }
}
