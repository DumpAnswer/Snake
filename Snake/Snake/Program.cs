﻿using System;
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
            Point p1 = new Point(5, 8, '*');

            p1.Draw();


            Console.ReadLine();
            



           
        }

    }
}