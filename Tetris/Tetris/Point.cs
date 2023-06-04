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
	}
}

