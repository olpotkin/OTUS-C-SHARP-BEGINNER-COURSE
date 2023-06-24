using System;

namespace Tetris
{
    static class Field
    {
        private static int _width = 40;
        private static int _height = 30;

        public static int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;

                // Only for Windows Platform:
                //Console.SetWindowSize(_width, Field.Height);
                //Console.SetBufferSize(_width, Field.Height);
            }
        }

        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;

                // Only for Windows Platform:
                //Console.SetWindowSize(Field.Width, _height);
                //Console.SetBufferSize(Field.Width, _height);
            }
        }

        private static bool[][] _heap;

        static Field()
        {
            // number of rows in array = Height
            _heap = new bool[Height][];

            // init each row as an array
            for (int i = 0; i < Height; ++i)
            {
                _heap[i] = new bool[Width];
            }
        }

        public static bool CheckStrike(Point p)
        {
            return _heap[p.Y][p.X];
        }

        public static void AddFigure(Figure fig)
        {
            foreach (var p in fig.Points)
            {
                _heap[p.Y][p.X] = true;
            }
        }

    }
}

