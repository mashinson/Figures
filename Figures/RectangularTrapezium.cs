using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class RectangularTrapezium : Trapezium
    {
        public RectangularTrapezium() : base("Rectangular Trapezium") { }

        public RectangularTrapezium(string name = "Rectangular Trapezium") : base(name) { }

        public RectangularTrapezium(Point[] points) : base("Rectangular Trapezium")
        {
            _vertices = new Point[4];
            for (int i = 0; i < 4; i++)
            {
                _vertices[i] = points[i];
            }
        }

        public override double Area
        {
            get
            {
                double base1 = 0;
                double base2 = 0;
                double h = 0;
                double ar = 0;
                base1 = Math.Sqrt(Math.Pow((_vertices[3].X - _vertices[0].X), 2) + Math.Pow(_vertices[3].Y - _vertices[0].Y, 2));
                base2 = Math.Sqrt(Math.Pow((_vertices[2].X - _vertices[1].X), 2) + Math.Pow(_vertices[2].Y - _vertices[1].Y, 2));               
                h = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));
                ar = (base1+ base2)/ 2 * h;
                return Math.Round(ar, 1);
            }

        }
    }
}
