using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Direction
    {
        private Directions _right;
        private Directions _left;
        private Directions _front;

        public Direction(Directions directions)
        {
            setDirection(directions);
        }

        public Directions GetDirections()
        {
            return _front;
        }
        public void TurnTo(Turn turn)
        {
            switch (turn)
            {
                case Turn.Left:
                    setDirection(_left);
                    break;
                case Turn.Right:
                    setDirection(_right);
                    break;
                default:
                    break;
            }
        }

        private void setDirection(Directions front)
        {
            _front = front;
            _left = getLeft(front);
            _right = getRight(front);
        }
        private Directions getLeft(Directions directions)
        {
            switch (directions)
            {
                case Directions.North:
                    return Directions.West;
                case Directions.East:
                    return Directions.North;
                case Directions.South:
                    return Directions.East;
                case Directions.West:
                    return Directions.South;
                default: return directions;
            }
        }
        private Directions getRight(Directions directions)
        {
            switch (directions)
            {
                case Directions.North:
                    return Directions.East;
                case Directions.East:
                    return Directions.South;
                case Directions.South:
                    return Directions.West;
                case Directions.West:
                    return Directions.North;
                default: return directions;
            }
        }

    }
}
