using System;

namespace Tetris
{
    internal class FigureGenerator
    {
        private int _x;                // x-position
        private int _y;                // y-position
        private char _c;               // character

        private Random _rand = new Random();

        public FigureGenerator(int x, int y, char c)
        {
            _x = x;
            _y = y;
            _c = c;
        }

        public Figure GetNewFigure()
        {
            if (_rand.Next(0, 2) == 0)
            {
                return new Square(_x, _y, _c);
            }
            else
            {
                return new Stick(_x, _y, _c);
            }
        }
    }
}