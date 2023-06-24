﻿using System.Reflection.Emit;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            // Only for Windows Platform:
            //Console.SetWindowSize(Field.Width, Field.Height);
            //Console.SetBufferSize(Field.Width, Field.Height);

            Field.Width = 30;

            FigureGenerator generator = new FigureGenerator(20, 0, '*');
            Figure currentFigure = generator.GetNewFigure();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    // var automatically replaces ConsoleKeyInfo
                    var key = Console.ReadKey();

                    HandleKey(currentFigure, key);
                }
            }
        }

        private static void HandleKey(Figure currentFigure, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    currentFigure.TryMove(Direction.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.TryMove(Direction.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.TryMove(Direction.DOWN);
                    break;
                case ConsoleKey.Spacebar:
                    currentFigure.TryRotate();
                    break;
            }
        }
    }
}
