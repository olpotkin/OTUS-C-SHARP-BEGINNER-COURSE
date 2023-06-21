using System.Reflection.Emit;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            // Only for Windows Platform:
            //Console.SetWindowSize(40, 30);
            //Console.SetBufferSize(40, 30);

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
                    currentFigure.Move(Direction.LEFT);
                    break;
                case ConsoleKey.RightArrow:
                    currentFigure.Move(Direction.RIGHT);
                    break;
                case ConsoleKey.DownArrow:
                    currentFigure.Move(Direction.DOWN);
                    break;
            }
        }
    }
}
