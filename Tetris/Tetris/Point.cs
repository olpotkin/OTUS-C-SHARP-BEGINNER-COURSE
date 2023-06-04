using System;
namespace Tetris
{
    class Point
    {
        public int x;
        public int y;
        public char c;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        // Constructor
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

