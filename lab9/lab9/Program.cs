using System;
using System.Drawing;
namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrate q = new Quadrate("lol", 0);
            q.Display();

            Quadrate b = new Quadrate("square 1", 213, "yellow");
            b.Display();

            Quadrate c = new Quadrate("Empty quadro");
            c.Display();
        }
    }
}
