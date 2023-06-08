﻿using System;

namespace Tetris
{
    public class Stick
    {
        Point[] points = new Point[4];

        public Stick(int x, int y, char sym)
        {
            points[0] = new Point(x, y + 1, sym);
            points[1] = new Point(x, y + 2, sym);
            points[2] = new Point(x, y + 3, sym);
            points[3] = new Point(x, y + 4, sym);
        }

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
