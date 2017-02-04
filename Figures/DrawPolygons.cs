using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class DrawPolygons
    {


        public static bool Сheckup(Point item)
        {
            bool bl = false;
            if (item.X < Console.WindowWidth && item.Y < Console.WindowHeight && item.X > 0 && item.Y > 1)
            {
                bl = true;
            }
            return bl;

        }

        public static void Draw(Polygon pl)
        {

            if (Сheckup(pl[0]))
            {
                Console.SetCursorPosition(pl[0].X, pl[0].Y - 2);
                Console.WriteLine(pl.Name);
            }
            for (int i = 0; i < pl.Len; i++)
            {
                if (Сheckup(pl[i]))
                {
                    Console.SetCursorPosition(pl[i].X, pl[i].Y);
                    Console.WriteLine("*");
                }
            }

            if (Сheckup(pl[pl.Len - 1]))
            {
                Console.SetCursorPosition(pl[pl.Len - 1].X, pl[pl.Len - 1].Y + 5);
                Console.WriteLine("Площадь {0}", pl.Area);
                Console.SetCursorPosition(pl[pl.Len - 1].X, pl[pl.Len - 1].Y + 6);
                Console.WriteLine("Периметр {0}", pl.Perimeter);
            }

        }
       

        }

    }

