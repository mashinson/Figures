using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class RegularPolygon : Polygon
    {
        public RegularPolygon() : base("Regular Polygon") { }
        public RegularPolygon(string name = "Regular Polygon") : base(name) { }
        public RegularPolygon(Point[] p) : base("Regular Polygon")
        {
            _vertices = new Point[p.Length];
            _vertices = p;
        }

        public override double Area
        {
            get
            {
                double side = 0;
                double ar = 0;
                side = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));
                ar = (side * side * (Len -1)) / (4 * Math.Tan(Math.PI/(Len-1)));

                return Math.Round(ar, 1);
            }

        }

        public override double Perimeter
        {
            get
            {
                double side = 0;                
                side = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));

                return Math.Round(side * (Len - 1), 1);
            }
        }
    }
}
