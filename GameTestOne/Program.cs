using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int origRow;
            int origCol;

             void WriteAt(string s, int x, int y)
            {
                try
                {
                    Console.SetCursorPosition(origCol + x, origRow + y);
                    Console.Write(s);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }

            Console.Clear();

            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;



            int x1 = 0;
            int y1 = 0;

            while (y1 < 16)
            {
                if (y1 == 0 || y1 == 15)
                {
                    WriteAt("+", x1, y1);
                }
                else
                {
                    WriteAt("|", x1, y1);
                }
                y1++;
            }
             x1 = 1;
             y1 = 0;

            while (x1 < 61)
            {
                if ( x1 == 60)
                {
                    WriteAt("+", x1, y1);
                }
                else
                {
                    WriteAt("--", x1, y1);
                }
                x1++;
            }
             x1 = 60;
             y1 = 1;

            while (y1 < 16)
            {
                if ( y1 == 15)
                {
                    WriteAt("+", x1, y1);
                }
                else
                {
                    WriteAt("|", x1, y1);
                }
                y1++;
            }
            x1 = 1;
            y1 = 15;

            while (x1 < 59)
            {
                    WriteAt("--", x1, y1);

                x1++;
            }




            WriteAt("All done!", 0, 20);
            Console.WriteLine();

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }


        }
    }
}
