using System.ComponentModel.DataAnnotations;
using Snake;
using static Snake.SnakeBody;

namespace SnakeGame;

public static class Game
{
    public static void StartPositions(GameBoard board)
    {
        SnakeBody snake = new SnakeBody();
        for (int i = 0; i < snake.SnakeSegments.Count; i++)
        {
            snake.SnakeSegments[i].PositionX(board.Board.GetLength(0) / 2);
            snake.SnakeSegments[i].PositionY(board.Board.GetLength(1) / 2);

        }
        
    }
    public static void EatAFruit()
    {

    }

    public static void EatYourself()
    {

    }

    public static void Movement()
    {

    }

    public static void GameOver()
    {

    }
}
