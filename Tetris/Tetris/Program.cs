using System.Reflection.Emit;

namespace Tetris
{
    class Program
    {
        static FigureGenerator generator;

        static void Main(string[] args)
        {
            // Only for Windows Platform:
            //Console.SetWindowSize(Field.Width, Field.Height);
            //Console.SetBufferSize(Field.Width, Field.Height);

            generator = new FigureGenerator(20, 0, '*');
            Figure currentFigure = generator.GetNewFigure();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    // var automatically replaces ConsoleKeyInfo
                    var key = Console.ReadKey();
                    var result = HandleKey(currentFigure, key.Key);
                    ProcessResult(result, ref currentFigure);
                }
            }
        }


        private static bool ProcessResult(Result result, ref Figure currentFigure)
        {
            if (result == Result.HEAP_STRIKE || result == Result.DOWN_BORDER_STRIKE)
            {
                Field.AddFigure(currentFigure);
                currentFigure = generator.GetNewFigure();
                return true;
            }
            else
                return false;
        }


        private static Result HandleKey(Figure f, ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    return f.TryMove(Direction.LEFT);
                case ConsoleKey.RightArrow:
                    return f.TryMove(Direction.RIGHT);
                case ConsoleKey.DownArrow:
                    return f.TryMove(Direction.DOWN);
                case ConsoleKey.Spacebar:
                    return f.TryRotate();
            }
            return Result.SUCCESS;
        }

    }
}
