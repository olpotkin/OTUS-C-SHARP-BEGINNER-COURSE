﻿using System;

namespace Tetris
{
    internal class FigureGenerator
    {
        // x-position
        private int _x;
        // y-position
        private int _y;
        // character
        private char _c;

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