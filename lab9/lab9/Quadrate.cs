using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace lab9
{
    public class Quadrate : Shape
    {
        private double sideA;
        public double Side
        {
            set
            {
                if (value <= 0)
                    sideA = 10;
                else
                {
                    sideA = value;
                }
            }
            get
            {
                return sideA;
            }
        }
        //overriding the Name prop
        public override string Name { get; set; }
        //overriding the NumberOfVertices prop
        public override int NumberOfVertices
        {
            get
            {
                return 4;
            }
        }
        public override string FigureColor { get; set; }

        //first constr with all params
        public Quadrate(string name, double side, string color)
        {
            Name = name;
            Side = side;
            FigureColor = color;
        }
        //second constr with two params
        public Quadrate(string name, double side)
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            Name = name;
            Side = side;
            FigureColor = randomColor.Name;
        }
        //third constr with one param
        public Quadrate(string name)
        {
            Name = name;

            Random r = new Random();
            Side = r.NextDouble()*10;

            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);

            FigureColor = randomColor.Name;
        }

        public override double Square()
        {
            return sideA * sideA;
        }

        public override double Perimeter()
        {
            return 2 * (sideA + sideA);
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}\nColor = {1}\nSquare = {2}\nPerimeter = {3}", Name, FigureColor, Square(), Perimeter());
        }
    }
}
