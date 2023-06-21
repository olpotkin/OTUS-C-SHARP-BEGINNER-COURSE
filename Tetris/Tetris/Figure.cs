﻿using System;

namespace Tetris
{
    public abstract class Figure
    {
        const int LENGTH = 4;
        protected Point[] points = new Point[LENGTH];

        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }


        internal void TryMove(Direction dir)
        {
            Hide();

            var clone = Clone();
            Move(clone, dir);

            if (VerifyPosition(clone))
            {
                points = clone;
            }

            Draw();
        }

        internal void TryRotate()
        {
            Hide();

            var clone = Clone();
            Rotate(clone);

            if (VerifyPosition(clone))
            {
                points = clone;
            }

            Draw();
        }

        private bool VerifyPosition(Point[] pList)
        {
            foreach(var p in pList)
            {
                if (p.x < 0 || p.y < 0 || p.x >= Field.WIDTH || p.y >= Field.HEIGHT)
                {
                    return false;
                }
            }

            return true;
        }

        private Point[] Clone()
        {
            var newPoints = new Point[LENGTH];
            for (int i = 0; i < LENGTH; ++i)
            {
                newPoints[i] = new Point(points[i]);
            }
            return newPoints;
        }

        public void Move(Point[] pList, Direction dir)
        {
            foreach (var p in pList)
            {
                p.Move(dir);
            }
        }

        //public void Move(Direction dir)
        //{
        //    Hide();
        //
        //    foreach (Point p in points)
        //    {
        //        p.Move(dir);
        //    }
        //
        //    Draw();
        //}


        public void Hide()
        {
            foreach (Point p in points)
            {
                p.Hide();
            }
        }

        public abstract void Rotate(Point[] pList);
    }
}

