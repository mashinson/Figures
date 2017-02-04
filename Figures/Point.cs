using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Point
    {
        public Point() : this(0, 0)
        {

        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point GetCopy()
        {
            Point p = (Point)MemberwiseClone();

            return p;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", _x, _y);
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }

        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }

        }

        private int _x = 0;
        private int _y = 0;
    }
}
