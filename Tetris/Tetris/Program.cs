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
            Figure s;

            while (true)
            {
                // out - guarantees that the object will be created
                FigureFall(out s, generator);
                s.Draw();
            }
        }


        static void FigureFall(out Figure fig, FigureGenerator generator)
        {
            fig = generator.GetNewFigure();
            fig.Draw();

            for (int i = 0; i < 15; ++i)
            {
                fig.Hide();
                fig.Move(Direction.DOWN);
                fig.Draw();
                Thread.Sleep(250);
            }
        }

    }
}
