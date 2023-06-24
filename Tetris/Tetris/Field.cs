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


    }
}

