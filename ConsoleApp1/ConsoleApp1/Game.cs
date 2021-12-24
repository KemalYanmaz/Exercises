using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        private Board _board;
        private int _placeX;
        private int _placeY;
        private Player _player;

        public Game(int width, int height,Player player)
        {
            _board = new Board(width, height);
            _player = player;
        }

        public Game(int width, int height,Direction direction)
        {
            _board = new Board(width, height);
            _player = new Player("Player", direction);
        }

        public void Start()
        {

        }
        public void TurnTo(Turn turn)
        {
            _player.TurnTo(turn);
        }
        public void MoveForward()
        {
            switch (_player.GetDirection().GetDirections())
            {
                case Directions.North:
                    increaseY();
                    break;
                case Directions.South:
                    decreaseY();
                    break ;
                case Directions.East:
                    increaseX();
                    break;
                case Directions.West:
                    decreaseX();
                    break;
            }
            
            Showboard();
        }

        public Player GetPlayer()
        {
            return _player;
        }

        public void Showboard()
        {
            _board.Show();
        }

        public int GetPlaceX()
        {
            return _placeX;
        }

        public int GetPlaceY()
        {
            return _placeY;
        }

        private void increaseY()
        {
            if (IsYIncreaseable())
            {
                _placeY++;
                _board.MarkCell(_placeX, _placeY);
            }
            else
            {
                PrintNotAllowedRoute();
            }
        }

        private void decreaseY()
        {
            if (IsPositive(_placeY))
            {
                _placeY--;
                _board.MarkCell(_placeX, _placeY);
            }
            else
            {
                PrintNotAllowedRoute();
            }

        }
        private void increaseX()
        {
            if (IsXIncreaseable())
            {
                _placeX++;
                _board.MarkCell(_placeX, _placeY);
            }
            else
            {
                PrintNotAllowedRoute();
            }
        }

        private void decreaseX()
        {
            if (IsPositive(_placeX))
            {
                _placeX++;
                _board.MarkCell(_placeX, _placeY);
            }
            else
            {
                PrintNotAllowedRoute();
            }
        }

        private bool IsPositive(int number)
        {
            return number > 0;
        }

        private bool IsXIncreaseable()
        {
            return _placeX + 1 < _board.GetWidth();
        }

        private bool IsYIncreaseable()
        {
            return _placeY + 1 < _board.GetHeight();
        }

        private void PrintNotAllowedRoute()
        {
            Console.WriteLine($"{_player.GetName()}, {_player.GetDirection().GetDirections()} yonunde daha fazla ilerleyemez.");
        }
    }
}
