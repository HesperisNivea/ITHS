using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Snake;
using static Snake.SnakeBody;

namespace SnakeGame;

public static class GameMechanics
{
    public static void StartPositions(GameBoard board,SnakeBody snake)
    {
        Point middlePoint = new Point((int)board.Board.GetLength(1)/2,(int)board.Board.GetLength(0)/2);
        
        Console.SetCursorPosition((int)board.Board.GetLength(1) / 2, (int)board.Board.GetLength(0) / 2);
        Console.WriteLine("ww");

        for (int i = 0; i < snake.SnakeSegments.Count; i++)
        {
            Size size = new Size(i, 0);
            snake.SnakeSegments[i] = middlePoint;
            snake.SnakeSegments[i] = Point.Add(snake.SnakeSegments[i],size);
            Console.SetCursorPosition(snake.SnakeSegments[i].X, snake.SnakeSegments[i].Y);
            Console.WriteLine("#");
        }
        
    }
    public static void EatAFruit()
    {
    }

    public static void EatYourself()
    {

    }

    public static void CollitionWithwall()
    {

    }
    public static void Movement()
    {

    }

    public static void GameOver()
    {

    }
}
