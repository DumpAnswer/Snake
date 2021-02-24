using Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class HorizanLine
    {
        List<Point> pList;

        public HorizanLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x<= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
        
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
