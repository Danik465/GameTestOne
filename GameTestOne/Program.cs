using System;
using System.Collections.Generic;
using System.Threading;

namespace GameTestOne
{

    public class Snake
    {

        public class Part
        {
            public int x, y, oldx , oldy;
            
        }
        public int HeadX, HeadY;
        public List<Part> parts = new List<Part>();
    }
    class Program
    {

        public static bool isStarted;
        public static int width =20, height =20;
        public static Snake snake;
       public enum move { up, down, left, right, stop }
        public static move dir = move.stop;



        public static void Init()
        {
            snake = new Snake() {HeadX = width/2, HeadY = height/2 , parts  = new List<Snake.Part>() { new Snake.Part() { x = (width / 2) - 1, y = height / 2 , oldx = (width/2)- 1, oldy = height/2} } };
            Console.CursorVisible = false;
            isStarted = true;
            dir = move.stop;
        }

    
       public static void Draw()
            {
                Console.Clear();
                for (int i = 0; i< height; i++)
                {
                    for(int j = 0; j < width; j++)
                     {
                        if (i == 0 || i == height -1)
                        {
                            Console.Write("|");
                            continue;
                        }
                        if (j == 0 || j ==width-1 )
                        {
                            Console.Write("|");
                        
                    }
                        else
                        {
                            Console.Write(" ");
                       
                    }
                     }
                    Console.Write("\n");
                }

            Console.SetCursorPosition(snake.HeadX, snake.HeadY);
            Console.Write("&");
            for(int i = 0; i < snake.parts.Count; i++ )
            {
                Console.SetCursorPosition(snake.parts[i].x, snake.parts[i].y);
                Console.Write("8");
            }
            }


        public static void Input()
        {
            if(Console.KeyAvailable)
            {
                var key = Console.ReadKey();
                switch (key.Key)
                { 
                    case ConsoleKey.UpArrow:
                        dir = move.up;
                        break;
                  case ConsoleKey.DownArrow:
                        dir = move.down;
                        break;
                    case ConsoleKey.LeftArrow:
                        dir = move.left;
                        break;
                    case ConsoleKey.RightArrow:
                        dir = move.right;
                        break;
                }
                   
            }      
        }
         

        public static void Logic()
        {
            int oldX = snake.HeadX, oldY = snake.HeadY;
            if( dir == move.up && dir != move.down)
            {
                snake.HeadY--;
                
            }
            if (dir != move.up && dir == move.down)
            {
                snake.HeadY++;
                
            }
            if (dir == move.left && dir != move.right)
            {
                snake.HeadX--;
                
            }
            if (dir != move.left && dir == move.right)
            {
                snake.HeadX++;
                
            }
            if (snake.HeadX == width || snake.HeadX == 0 || snake.HeadY == 0 || snake.HeadY == height-1)
            {
                isStarted = false;
            }
            if(dir != move.stop)
            {
                for(int i = 0; i < snake.parts.Count; i++ )
                {
                    if (i== 0) { snake.parts[i].x = oldX; snake.parts[i].y = oldY; continue; };
                    snake.parts[i].x = snake.parts[i - 1].x;
                    snake.parts[i].y = snake.parts[i - 1].y;
                    snake.parts[i].oldx = snake.parts[i].x;
                    snake.parts[i].oldy = snake.parts[i].y;
                }
            }

            
        }
        static void Main(string[] args)
        {

            Init();
            while(isStarted)
            {
                Input();
                Draw();
                Logic();
                Thread.Sleep(1000);    
            }    




  

   


        }
    }
}
