namespace Snake;

public class SnakeBody
{
    public List<SnakeSegment> SnakeSegments { get; set; } = new List<SnakeSegment>();
    private SnakeSegment snakeSegment { get; set; }

    public SnakeBody()
    {
        for (int i = 0; i < 10; i++)
        {
            SnakeSegments.Add(snakeSegment);
        }
    }

    
}