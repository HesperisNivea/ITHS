using System.Drawing;

namespace Snake;

public class SnakeBody
{
    private Point _snakeSegment;
    public List<Point> SnakeSegments { get; set; } = new List<Point>();
    public Point SnakeSegment { get; set; } 

    public SnakeBody()
    {

        for (int i = 0; i < 3; i++)
        {
            //_snakeSegment.X = 2 + i;
            //_snakeSegment.Y = 2 + i;
            SnakeSegments.Add(_snakeSegment);
        }

        foreach (var point in SnakeSegments)
        {
            //Console.WriteLine(point);
        }
        
    }

    
}