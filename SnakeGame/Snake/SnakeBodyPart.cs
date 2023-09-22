using System.Drawing;

namespace Snake;

public class SnakeBodyPart
{
    private Point _snakeBodypartPoint; 
    public Point SnakeBodyPartPoint { get; set; } = new Point();

    public SnakeBodyPart()
    {
        
    }

    public SnakeBodyPart(int startPositionX, int startPositionY)
    {
       
        _snakeBodypartPoint.Y = startPositionY ;
        _snakeBodypartPoint.X = startPositionX;
        _snakeBodypartPoint = SnakeBodyPartPoint;
    }
}