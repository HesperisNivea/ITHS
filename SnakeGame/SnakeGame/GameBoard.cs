using System.Security.Principal;
using System.Drawing;
using Snake;

namespace SnakeGame;

public class GameBoard
{
    Point boardPoint = new Point(0,0);
    public char[,] Board { get; private set; } = new char[25,25];

    public GameBoard( )
    { 

    }

    public static void WindowSize(char[,] board) // copied from MicrosoftDocs for testing :) 
    {
        int originalWidth, originalHeight;
        int width = board.GetLength(1);
        int height = board.GetLength(0);

        originalWidth = Console.WindowWidth;
        originalHeight = Console.WindowHeight;
        Console.WriteLine("The current window width is {0}, and the " +
                    "current window height is {1}.",Console.WindowWidth,
            Console.WindowHeight);

        Console.ReadLine(); // just for testing
        Console.SetWindowSize(originalWidth,originalHeight);
        Console.WriteLine("The new window width is {0}, and the new " +
                          "window height is {1}.",Console.WindowWidth,
            Console.WindowHeight);

    }
    //// Maybe some other day :)

    //public void BoardSetUp(char[,] board)
    //{
    //    Console.CursorVisible = true;

    //    for (int i = 0; i < board.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < board.GetLength(1); j++)
    //        {
    //            if ( i == 0 || j == 0 || i == (int)(board.GetLength(0) - 1) || j == (int)(board.GetLength(1) - 1))
    //            {
    //                Console.Write("@");
    //            }
    //            else
    //            {
    //                Console.Write(" ");
    //            }
               
    //        }
            
    //        Console.WriteLine();
            
    //    }
    //}

    public void BoardSetUp(char[,] board)  // QQ 
    {
        boardPoint = Point.Empty;
        Console.SetCursorPosition(boardPoint.X,boardPoint.Y);
        Size size = new Size(0,0);
        size.Width = 2;
        
        for (int i = 0; i <= board.GetLength(1) + 1; i++)
        {
            Console.SetCursorPosition(boardPoint.X, boardPoint.Y);
            Console.Write("@");
            boardPoint = Point.Add(boardPoint, size);

        }
        size.Width = 0;
        size.Height = 1;
       
        for (int i = board.GetLength(0); i >= 0; i--)
        {
            Console.SetCursorPosition(boardPoint.X, boardPoint.Y);
            Console.Write("@");
            boardPoint =  Point.Add(boardPoint, size);
        }

        size.Width = 2;
        size.Height = 0;
        
        for (int i = 0; i <= board.GetLength(1) + 1; i++)
        {
            Console.SetCursorPosition(boardPoint.X, boardPoint.Y);
            Console.Write("@");
            boardPoint =  Point.Subtract(boardPoint, size);

        }

        size.Width = 0;
        size.Height = 1;
       
        for (int i = board.GetLength(0); i >= 0; i--)
        {
            Console.SetCursorPosition(boardPoint.X, boardPoint.Y);
            Console.Write("@");
            boardPoint =  Point.Subtract(boardPoint, size);
        }

    }


    public void UpdateScreen()
    {
        
    }

}