using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Parallelogram
    {
        public Rectangle() : base("Rectangle") { }
        public Rectangle(string name = "Rectangle") : base(name) { }
        public Rectangle(Point[] points) : base("Rectangle") 
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
                double side1 = 0;
                double side2 = 0;
                double ar = 0;
               side1 = Math.Sqrt(Math.Pow((_vertices[1].X - _vertices[0].X), 2) + Math.Pow(_vertices[1].Y - _vertices[0].Y, 2));
                side2 = Math.Sqrt(Math.Pow((_vertices[2].X - _vertices[1].X), 2) + Math.Pow(_vertices[2].Y - _vertices[1].Y, 2));
                ar = side1 * side2;

                return Math.Round(ar, 1);
            }

        }
       
        //public override void Draw()
        //{


        //    Console.SetCursorPosition(_x1, _y1);
        //    for (int i = 0; i <= _x4 - _x1; i++)
        //    {
        //        Console.Write("█");
        //    }
        //    Console.SetCursorPosition(_x2, _y2);
        //    for (int i = 0; i <= _x3 - _x2; i++)
        //    {
        //        Console.Write("█");
        //    }

        //    int row = _y2;
        //    for (int i = 0; i <= _y1 - _y2; i++)
        //    {
        //        Console.SetCursorPosition(_x2, row);
        //        row += 1;
        //        Console.WriteLine("█");
        //    }
        //    row = _y3;
        //    for (int i = 0; i <= _y4 - _y3; i++)
        //    {
        //        Console.SetCursorPosition(_x3, row);
        //        row += 1;
        //        Console.WriteLine("█");
        //    }
        //}


    }



}
