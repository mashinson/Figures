using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle() : base("Isosceles Triangle") { }
        protected IsoscelesTriangle(string name = "Isosceles Triangle") : base(name) { }

        public IsoscelesTriangle(Point[] points) : base("Isosceles Triangle")
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
                double side1 = 0;
                double side2 = 0;
                double ar = 0;

                side2 = Math.Sqrt(Math.Pow((_vertices[2].X - _vertices[1].X), 2) + Math.Pow(_vertices[2].Y - _vertices[1].Y, 2));
                side1 = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));
                ar = (side2 * Math.Sqrt(side1 * side1 - (side2 * side2 / 4))) / 2;
                return Math.Round(ar, 1);
            }

        }
    }
}
