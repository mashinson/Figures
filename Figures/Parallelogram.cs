using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Parallelogram : Quadrangle
    {
        public Parallelogram() : base("Parallelogram") { }
        protected Parallelogram(string name = "Parallelogram") : base(name) { }

        public Parallelogram(Point[] points) : base("Parallelogram")
        {
            _vertices = new Point[4];
            for (int i = 0; i < 4; i++)
            {
                _vertices[i] = points[i];
            }
        }
        
        public override double Perimeter
        {
            get
            {
                double side1 = 0;
                double side2 = 0;
                double per = 0;
                side1 = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));
                side2 = Math.Sqrt(Math.Pow((_vertices[2].X - _vertices[1].X), 2) + Math.Pow(_vertices[2].Y - _vertices[1].Y, 2));
                per = (side1 + side2) * 2;
                return Math.Round(per, 1);
            }
        }

        


      


    }
}
