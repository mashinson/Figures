using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Polygon : Figure
    {
        public Polygon() : base("Poligon") { }
        protected Polygon(string name = "Poligon") : base(name) { }

        public Polygon(Point[] p) : base("Poligon")
        {
            _vertices = new Point[p.Length];
            _vertices = p;
        }
        public override double Perimeter
        {
            get
            {
                double side = 0;
                double per = 0;
                for (int i = 0; i < _vertices.Length - 1; i++)
                {
                    side = Math.Sqrt(Math.Pow((_vertices[i + 1].X - _vertices[i].X), 2) + Math.Pow(_vertices[i + 1].Y - _vertices[i].Y, 2));
                    per += side;
                }
                side = Math.Sqrt(Math.Pow((_vertices[_vertices.Length - 1].X - _vertices[0].X), 2) + Math.Pow(_vertices[_vertices.Length - 1].Y - _vertices[0].Y, 2));
                per += side;
                return Math.Round(per, 1);
            }
        }
        public override double Area
        {
            get
            {
                int sum1 = 0;
                int sum2 = 0;

                for (int i = 0; i < _vertices.Length - 1; i++)
                {
                    sum1 += _vertices[i].X * _vertices[i + 1].Y;

                    sum2 += _vertices[i].Y * _vertices[i + 1].X;
                }
                sum1 += _vertices[_vertices.Length - 1].X * _vertices[0].Y;
                sum2 += _vertices[_vertices.Length - 1].Y * _vertices[0].X;

                return Math.Abs((sum1 - sum2) / 2);
            }
        }

        public virtual Point this[int t]
        {
            get

            {
                Point p = new Point();
                p = _vertices[t];
                return p;
            }

        }
        public int Len
        {
            get
            {
                return _vertices.Length;
            }


        }
        public override void Move(int x, int y)
        {
            foreach (var item in _vertices)
            {
                item.X = item.X + x;
                item.Y = item.Y + y;
            }

        }


        protected Point[] _vertices;

    }
}
