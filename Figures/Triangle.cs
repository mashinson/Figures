using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : Polygon
    {

        public Triangle() : base("Triangle") { }
        protected Triangle(string name = "Triangle") : base(name) { }

        public Triangle(Point[] points) : base("Triangle")
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
                double ar = 0;
                double p = 0;
                double[] side = new double[3];

                for (int i = 0; i < _vertices.Length - 1; i++)
                {
                    side[i] += Math.Sqrt(Math.Pow((_vertices[i + 1].X - _vertices[i].X), 2) + Math.Pow(_vertices[i + 1].Y - _vertices[i].Y, 2));
                    p += side[i];
                }
                side[side.Length - 1] += Math.Sqrt(Math.Pow((_vertices[_vertices.Length - 1].X - _vertices[0].X), 2) + Math.Pow(_vertices[_vertices.Length - 1].Y - _vertices[0].Y, 2));
                p += side[side.Length - 1];
                p = p / 2;
                ar = Math.Sqrt(p *(p - side[0]) * (p - side[1]) * (p - side[2]));

                return Math.Round(ar, 1);
            }

        }

        public override double Perimeter
        {
            get
            {          
                double p = 0;               
                for (int i = 0; i < _vertices.Length - 1; i++)
                {
                    p += Math.Sqrt(Math.Pow((_vertices[i + 1].X - _vertices[i].X), 2) + Math.Pow(_vertices[i + 1].Y - _vertices[i].Y, 2));               
                }
                p += Math.Sqrt(Math.Pow((_vertices[_vertices.Length - 1].X - _vertices[0].X), 2) + Math.Pow(_vertices[_vertices.Length - 1].Y - _vertices[0].Y, 2));

                return Math.Round(p, 1);
            }
        }

    }
}
