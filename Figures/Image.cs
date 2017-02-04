using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Image
    {
        public Image(int size = 100)
        {
            _figures = new Figure[size];
        }

        public void AddFigure(Figure f)
        {
            _figures[_size++] = f;
        }


        public void DrawImage()
        {

            foreach (var item in _figures)
            {
                if (item is Polygon)
                {
                    DrawPolygons.Draw((Polygon)item);
                }
                if (item is Ellipse)
                {
                    DrawEllipse.Draw((Ellipse)item);
                }
               

            }
        }


        public bool MoveFigures(Action action)
        {
            bool bl = true;

            foreach (var pol in _figures)
            {
                switch (action)
                {
                    case Action.Left:
                        pol.Move(-1, 0);
                        break;
                    case Action.Right:
                        pol.Move(1, 0);
                        break;
                    case Action.Top:
                        pol.Move(0, -1);
                        break;
                    case Action.Bottom:
                        pol.Move(0, 1);
                        break;
                    case Action.Exit:
                        bl = false;
                        break;
                }
            }

            return bl;
        }


        private int _size = 0;
        private Figure[] _figures = null;
    }
}

