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
            if (pList[0].X == pList[1].X)
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
                pList[i].X = pList[0].X;
                pList[i].Y = pList[0].Y + i;
            }
        }

        private void RotateHorizontal(Point[] pList)
        {
            for (int i = 0; i < pList.Length; ++i)
            {
                pList[i].Y = pList[0].Y;
                pList[i].X = pList[0].X + i;
            }
        }

    }
}

