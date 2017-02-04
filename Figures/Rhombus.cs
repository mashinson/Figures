using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures  
{
    class Rhombus : Parallelogram
    {
        public Rhombus() : base("Rhombus") { }
        protected Rhombus(string name = "Rhombus") : base(name) { }

        public Rhombus(Point[] points) : base("Rhombus")
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
                double side = 0;
                double per = 0;
                side = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));
                per = side * 4;
                return Math.Round(per, 1);
            }
        }

        

    }
}
