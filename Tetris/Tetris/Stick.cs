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

            Draw();
        }

        public override void Rotate(Point[] pList)
        {
            // vertical -> horizontal
            if (pList[0].x == pList[1].x)
            {
                RotateHorizontal(pList);
            }
            // horizontal -> vertical
            else
            {
                RotateVertical(pList);
            }
        }

        private void RotateVertical(Point[] pList)
        {
            for (int i = 0; i < pList.Length; ++i)
            {
                pList[i].x = pList[0].x;
                pList[i].y = pList[0].y + i;
            }
        }

        private void RotateHorizontal(Point[] pList)
        {
            for (int i = 0; i < pList.Length; ++i)
            {
                pList[i].y = pList[0].y;
                pList[i].x = pList[0].x + i;
            }
        }

    }
}

