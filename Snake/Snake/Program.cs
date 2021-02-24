using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(85, 25);
            Console.SetBufferSize(85, 25);

            ///Отрисовка рамочки
            HorizanLine upLine = new HorizanLine(0, 78, 0, '+');
            HorizanLine downLine = new HorizanLine(0, 78, 24, '+');            
            VertikalLine leftLine = new VertikalLine(0, 24, 0, '+');
            VertikalLine rightLine = new VertikalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            /// Отрисовка точек
            Point p = new Point(5, 8, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
          
            Console.ReadLine();
            



           
        }

    }
}