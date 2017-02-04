using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Ellipse : Figure
    {
        public Ellipse() : base("Ellipse") { }
        protected Ellipse(string name = "Ellipse") : base(name) { }

        public Ellipse(Point center, int a, int b) : base("Ellipse")
        {
            _center = center;
            _a = a;
            _b = b;
        }
        public override double Perimeter
        {
            get
            {
                double per = 0;
                per = 4 * ((Math.PI * _a * _b + (_a - _b)) / (_a + _b));
                return Math.Round(per, 1);

            }
        }
        public override double Area
        {
            get
            {
                double ar = 0;
                ar = Math.PI * _a * _b;

                return Math.Round(ar, 1); ;
            }
        }
        public Point Center
        {
            get
            {
                return _center;
            }

        }
        public int A
        {
            get
            {
                return _a;
            }

        }

        public int B
        {
            get
            {
                return _b;
            }

        }

        public override void Move(int x, int y)
        {
            _center.X = _center.X + x;
            _center.Y = _center.Y + y;            
        }


        protected int _a;
        protected int _b;
        protected Point _center;
    }
}
