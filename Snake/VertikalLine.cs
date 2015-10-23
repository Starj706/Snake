using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertikalLine
    {
        List<Point> pList;

        public VertikalLine(int x, int yTop, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void DrowV()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
