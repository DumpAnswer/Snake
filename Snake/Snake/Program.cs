using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');

            p1.Draw();

            Point p2 = new Point(4, 5, '#');

            p2.Draw(); 

            HorizanLine line = new HorizanLine(0, 20, 10, '+');
            line.Drow();

            VertikalLine line1 = new VertikalLine(0, 10, 0, '+');
            line1.Drow();

            Console.ReadLine();
            



           
        }

    }
}