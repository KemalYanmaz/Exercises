using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        private string _name;
        private Direction _direction;

        public Player(string name, Direction direction)
        {
            _name = name;
            _direction = direction;

        }

        public void TurnTo(Turn turn)
        {
            _direction.TurnTo(turn);
        }

        public Direction GetDirection()
        {
            return _direction;
        }

        public string GetName()
        {
            return _name;
        }
    }

}
