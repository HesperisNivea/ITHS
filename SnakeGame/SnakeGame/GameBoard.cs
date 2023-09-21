using System.Security.Principal;

namespace SnakeGame;

public class GameBoard
{
    public char[,] Board { get; private set; } = new char[7, 7];

    public GameBoard( )
    {
       
    }

    //public static void WindowSize(char[,] board)
    //{
    //    Console.LargestWindowHeight.CompareTo(board.GetLength(0));
    //    Console.LargestWindowWidth
    //}
    //// Maybe some other day :)
    /// 
    public void BoardSetUp(char[,] board)
    {
        Console.CursorVisible = true;

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if ( i == 0 || j == 0 || i == (int)(board.GetLength(0) - 1) || j == (int)(board.GetLength(1) - 1))
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write(" ");
                }
               
            }
            
            Console.WriteLine();
            
        }
    }
    public void UpdateScreen()
    {
        
    }

}