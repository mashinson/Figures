using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : Ellipse
    {
        public Circle() : base("CIrcle") { }
        protected Circle(string name = "CIrcle") : base(name) { }

        public Circle(Point center, int r) : base("CIrcle")
        {
            _center = center;            
            _a= r;
            _b = r;
        }
        public override double Perimeter
        {
            get
            {
                return Math.Round(2 * Math.PI * _a, 1);

            }
        }
        public override double Area
        {
            get
            {
                double ar = 0;
                ar = Math.PI * _a * _a;

                return Math.Round(ar, 1); ;
            }
        }
      
        public int Radius
        {
            get
            {
                return _a;
            }

        }

       

        public override void Move(int x, int y)
        {
            _center.X = _center.X + x;
            _center.Y = _center.Y + y;
        }

       
    }
}
