using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class RectangularTriangle : Triangle
    {
        public RectangularTriangle() : base("Rectangular Triangle") { }
        protected RectangularTriangle(string name = "Rectangular Triangle") : base(name) { }

        public RectangularTriangle(Point[] points) : base("Rectangular Triangle")
        {
            _vertices = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                _vertices[i] = points[i];
            }            
        }
        public override double Area
        {
            get
            {
                double side = 0;
                double h = 0;
                double ar = 0;

                side = Math.Sqrt(Math.Pow((_vertices[2].X - _vertices[1].X), 2) + Math.Pow(_vertices[2].Y - _vertices[1].Y, 2));
                h = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));
                ar = side * h / 2;
                return Math.Round(ar, 1);
            }

        }

    }
}
