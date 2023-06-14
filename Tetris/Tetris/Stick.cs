using System;

namespace Tetris
{
    public class Stick : Figure
    {
        public Stick(int x, int y, char sym)
        {
            points[0] = new Point(x, y + 1, sym);
            points[1] = new Point(x, y + 2, sym);
            points[2] = new Point(x, y + 3, sym);
            points[3] = new Point(x, y + 4, sym);
        }

        public override void Rotate()
        {
            // vertical -> horizontal
            if (points[0].x == points[1].x)
            {
                RotateHorizontal();
            }
            // horizontal -> vertical
            else
            {
                RotateVertical();
            }
        }

        private void RotateVertical()
        {
            for (int i = 0; i < points.Length; ++i)
            {
                points[i].x = points[0].x;
                points[i].y = points[0].y + i;
            }
        }

        private void RotateHorizontal()
        {
            for (int i = 0; i < points.Length; ++i)
            {
                points[i].y = points[0].y;
                points[i].x = points[0].x + i;
            }
        }

    }
}

