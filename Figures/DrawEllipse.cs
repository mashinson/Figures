using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class DrawEllipse
    {
        public static bool Сheckup(Ellipse el)
        {
            bool bl = false;
            if ((el.Center.X + el.A) < Console.WindowWidth && (el.Center.Y + el.B) < Console.WindowHeight && (el.Center.X - el.A) > 0 && (el.Center.Y - el.B) > 1)
            {
                bl = true;
            }
            return bl;

        }

        public static void Draw(Ellipse el)
        {
            if (Сheckup(el))
            {
                Console.SetCursorPosition(el.Center.X, el.Center.Y - el.B - 2);
                Console.WriteLine(el.Name);
                Point p = new Point();
            for (double t = 0; t < 2* Math.PI; t += 0.25)
            {
                p.X = (int)(Math.Floor(el.A * Math.Cos(t) + el.Center.X));
                p.Y = (int)(Math.Floor(el.B * Math.Sin(t) + el.Center.Y));
                
                Console.SetCursorPosition(p.X, p.Y);
                Console.WriteLine("*");
            }

            Console.SetCursorPosition(el.Center.X, el.Center.Y + el.B + 2);
            Console.WriteLine("Площадь {0}", el.Area);
            Console.SetCursorPosition(el.Center.X, el.Center.Y + el.B + 3);
            Console.WriteLine("Периметр {0}", el.Perimeter);
            }
        }
    }
}
