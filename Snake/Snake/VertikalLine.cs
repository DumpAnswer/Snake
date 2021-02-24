using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    class VertikalLine : Figure
    {
        public VertikalLine(int yUp, int yDawn, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yUp; y <= yDawn; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }

    
    }
}
