using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public abstract class Shape
    {
        public abstract string Name { get; set; }
        public abstract string FigureColor { get; set; }
        public abstract int NumberOfVertices { get; }

        public abstract double Square();
        public abstract double Perimeter();
        public abstract void Display();

    }
}
