﻿using System;

namespace Tetris
{
    public class Point
    {
        public int x;
        public int y;
        public char c;


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            Console.SetCursorPosition(0, 0);
        }


        internal void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.DOWN:
                    y += 1;
                    break;
                case Direction.LEFT:
                    x -= 1;
                    break;
                case Direction.RIGHT:
                    x += 1;
                    break;
            }
        }


        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }


        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            c = p.c;
        }

        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;
        }

        // Default Constructor
        public Point() { }
    }
}

