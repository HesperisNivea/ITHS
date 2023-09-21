using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class BoardSegment
    {
        public char Segment { get; private set; } = '%';
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public BoardSegment()
        {
           
        }

        public BoardSegment(int positionX, int positionY, char segment)
        {
            PositionX = positionX;
            PositionY = positionY;
            Segment = segment;
        }
    }
}
