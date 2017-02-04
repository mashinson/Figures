using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Trapezium : Quadrangle
    {
        public Trapezium() : base("Trapezium") { }

        public Trapezium(string name = "Trapezium") : base(name) { }

        public Trapezium(Point[] points) : base("Trapezium")
        {
            _vertices = new Point[4];
            for (int i = 0; i < 4; i++)
            {
                _vertices[i] = points[i];
            }
        }

    }
}
