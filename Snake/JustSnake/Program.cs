using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustSnake

{
   struct Position
    {
        public int row;
        public int col;
        public Position (int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    


    }



    class Program
    {
        static void Main(string[] args)


        {
            byte right = 0;
            byte left = 1;
            byte down = 2;
            byte up = 3;

            int lastFoodTime = 0;
            int foodDisappearTime = 8000;
            //DateTime.Now


            Position[] directions = new Position[]
            {
                new Position(0,1), // right
                new Position(0,-1), // left
                new Position(1,0), // down
                new Position(-1,0), // top
            };
            int direction = right; // 0
            double sleepTime = 100;
            Random randomNumberGenerator = new Random();

            Console.BufferHeight = Console.WindowHeight;

            Position food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowHeight));
            lastFoodTime = Environment.TickCount;
         

            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }

            foreach (Position position in snakeElements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.Write("*");
            }

            while (true)
            {


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (userInput.Key == ConsoleKey.LeftArrow)
                    {
                        if (direction != right ) direction = left;
                    }
                    if (userInput.Key == ConsoleKey.RightArrow)
                    {
                        if (direction != left) direction = right;
                    }
                    if (userInput.Key == ConsoleKey.UpArrow)
                    {
                        if (direction != down) direction = up;
                    }
                    if (userInput.Key == ConsoleKey.DownArrow)
                    {
                        if (direction != up) direction = down;
                    }
                }

                Position snakeHead = snakeElements.Last();

                Position nextDirection = directions[direction];

                Position snakeNewHead = new Position(snakeHead.row + nextDirection.row, snakeHead.col + nextDirection.col);


                if (snakeNewHead.row < 0 || snakeNewHead.col < 0 || snakeNewHead.row >= Console.WindowHeight || snakeNewHead.col >= Console.WindowWidth || snakeElements.Contains(snakeNewHead))

                {
                    Console.SetCursorPosition(0, 0);
                    
                    Console.WriteLine("GAME OVER!");
                    Console.WriteLine("Your points are {0}", (snakeElements.Count - 6) * 100);

                    return;

                }
                Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);

                if (direction == right) Console.Write(">");
                if (direction == left) Console.Write("<");
                if (direction == up) Console.Write("^");
                if (direction == down) Console.Write("v");

                snakeElements.Enqueue(snakeNewHead);

                if (snakeNewHead.col == food.col && snakeNewHead.row == food.row)

                {
                    do
                    {
                        food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowHeight));
                        //TODO
                    }

                    while (snakeElements.Contains(food));
                    lastFoodTime = Environment.TickCount;

                    sleepTime--;
                }
                else
                {

                    snakeElements.Dequeue();
                }

               

               
             
               

                Console.Clear();
                foreach (Position position in snakeElements)
                {
                    Console.SetCursorPosition(position.col, position.row);
                    Console.Write("*");
                }
                if (Environment.TickCount - lastFoodTime >= foodDisappearTime)

                {
                    Console.SetCursorPosition(food.col, food.row);
                    Console.Write(" ");

                    do
                    {
                        food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), randomNumberGenerator.Next(0, Console.WindowHeight));
                        //TODO
                    }

                    while (snakeElements.Contains(food));
                    lastFoodTime = Environment.TickCount;

                }

                Console.SetCursorPosition(food.col, food.row);
                Console.Write("@");

                
               sleepTime -= 0.01;

                Thread.Sleep((int)sleepTime);

            }

           
        }
    }
}
