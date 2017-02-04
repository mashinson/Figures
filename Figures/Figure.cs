using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Figure
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        public string Name { get; }
        public Figure(string name)
        {
            Name = name;
        }
        //public abstract void Draw();
        public abstract void Move(int x, int y);


    }
}
