﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{ 
    class VertikalLine : Figure
    {
     public VertikalLine(int x, int yTop, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
        
    }
}
