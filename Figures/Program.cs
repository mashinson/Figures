using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOZORDER = 0x0004;
        const UInt32 SWP_NOREDRAW = 0x0008;
        const UInt32 SWP_NOACTIVATE = 0x0010;
        const UInt32 SWP_FRAMECHANGED = 0x0020;
        const UInt32 SWP_SHOWWINDOW = 0x0040;
        const UInt32 SWP_HIDEWINDOW = 0x0080;
        const UInt32 SWP_NOCOPYBITS = 0x0100;
        const UInt32 SWP_NOOWNERZORDER = 0x0200;
        const UInt32 SWP_NOSENDCHANGING = 0x0400;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);





        static void Main(string[] args)
        {
            IntPtr ConsoleHandle = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            const UInt32 WINDOW_FLAGS = SWP_SHOWWINDOW;

            // Здесь 0,0 - позиция окна (x, y)     700 - ширина       600 - высота
            SetWindowPos(ConsoleHandle, HWND_NOTOPMOST, 0, 0, 850, 600, WINDOW_FLAGS);

            Image im = new Image(18);

            Point[] points = new Point[] { new Point(3, 2), new Point(3, 5), new Point(6, 5), new Point(8, 3), new Point(6, 2) };
            Polygon pol = new Polygon(points);
            im.AddFigure(pol);


            points = new Point[] { new Point(21, 2), new Point(22, 5), new Point(24, 6), new Point(26, 2) };
            Quadrangle quad = new Quadrangle(points);
            im.AddFigure(quad);

            points = new Point[] { new Point(40, 2), new Point(40, 5), new Point(42, 5), new Point(42, 2) };
            Rectangle rec = new Rectangle(points);
            im.AddFigure(rec);

            points = new Point[] { new Point(55, 2), new Point(55, 6), new Point(59, 6), new Point(59, 2) };
            Square sq = new Square(points);
            im.AddFigure(sq);

            points = new Point[] { new Point(80, 2), new Point(77, 5), new Point(82, 5), new Point(85, 2) };
            Parallelogram pr = new Parallelogram(points);
            im.AddFigure(pr);

            points = new Point[] { new Point(105, 2), new Point(103, 5), new Point(105, 8), new Point(107, 5) };
            Rhombus rh = new Rhombus(points);
            im.AddFigure(rh);


            points = new Point[] { new Point(2, 20), new Point(1, 23), new Point(7, 23), new Point(5, 20) };
            Trapezium tr = new Trapezium(points);
            im.AddFigure(tr);

            points = new Point[] { new Point(25, 20), new Point(22, 23), new Point(31, 23), new Point(28, 20) };
            IsoscelesTrapezium it = new IsoscelesTrapezium(points);
            im.AddFigure(it);


            points = new Point[] { new Point(53, 20), new Point(53, 24), new Point(61, 24), new Point(57, 20) };
            RectangularTrapezium rt = new RectangularTrapezium(points);
            im.AddFigure(rt);

            Ellipse el = new Ellipse(new Point(85, 24), 10, 3);
            im.AddFigure(el);

            Circle cr = new Circle(new Point(110, 24), 5);
            im.AddFigure(cr);

            points = new Point[] { new Point(5, 40), new Point(2, 45), new Point(7, 45) };
            Triangle trian = new Triangle(points);
            im.AddFigure(trian);

            points = new Point[] { new Point(25, 40), new Point(25, 45), new Point(30, 45) };
            RectangularTriangle rect = new RectangularTriangle(points);
            im.AddFigure(rect);

            points = new Point[] { new Point(55, 40), new Point(50, 45), new Point(60, 45) };
            IsoscelesTriangle iso = new IsoscelesTriangle(points);
            im.AddFigure(iso);

            points = new Point[] { new Point(84, 40), new Point(80, 42), new Point(82, 45), new Point(86, 45), new Point(88, 42) };
            RegularPolygon fivepol = new RegularPolygon(points);
            im.AddFigure(fivepol);


            points = new Point[] { new Point(103, 40), new Point(101, 41), new Point(100, 43), new Point(101, 45), new Point(103, 46), new Point(105, 45), new Point(106, 43), new Point(105, 41) };
            RegularPolygon rp = new RegularPolygon(points);
            im.AddFigure(rp);

            points = new Point[] { new Point(3, 60), new Point(2, 63), new Point(3, 66), new Point(7, 66),  new Point(7, 60),new Point(8, 63) };
            RegularHexagon heg = new RegularHexagon(points);
            im.AddFigure(heg);

            points = new Point[] { new Point(32, 60), new Point(30, 64), new Point(34, 64) };
            RegularTriangle regt = new RegularTriangle(points);
            im.AddFigure(regt);


            im.DrawImage();
            bool bl = true;
            Action action;
            while (bl)
            {
                action = UserActions.GetUserAction();
                bl = im.MoveFigures(action);
                Console.Clear();
                im.DrawImage();
            }

        }
    }
}
