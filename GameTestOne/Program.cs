using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTestOne
{
    class Program
    {
       public enum move { up, down, left, right };
       public move dir = move.up;
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


            void Draw()
            {
                int X = 0;
                int Y = 0;
               Console.SetCursorPosition(X, Y);
                Console.Write("0");
            }
            Draw();
            
           void Input()
            {
                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    switch (key.KeyChar)
                    {
                        case "W":
                            dir = move.up;
                        case "S":
                            dir = move.down;
                        case "A":
                            dir = move.left;
                        case "D":
                            dir = move.right;

                    }
                }
            }

            void Logic()
            {
                if (dir == move.up)
                {

                }
            }


            /*    int[,] pic = new int[,]
            {
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, },
            };

                  void PrintImage(int[,] image)
            {
                for (int i = 0; i < image.GetLength(0); i++)
                {
                    for (int j = 0; j < image.GetLength(1); j++)
                    {
                        // Console.Write($"{image[i, j]} ");
                        if (image[i,j] == 0) Console.Write($" ");
                        else Console.Write($"+");
                    }
                    Console.WriteLine();
                }
            }



                PrintImage(pic);

           */
            WriteAt("All done!", 0, 20);
            Console.WriteLine();

            Console.WriteLine();

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }


        }
    }
}
