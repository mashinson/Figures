

namespace Figures
{
    class Quadrangle: Polygon
    {
        public Quadrangle() : base("Quadrangle") { }

        public Quadrangle(string name = "Quadrangle") : base(name) { }

        public Quadrangle(Point[] points) : base("Quadrangle")
        {
            _vertices = new Point[4];
            for (int i = 0; i < 4; i++)
            {
                _vertices[i] = points[i];
            }
        }       
    }
}
