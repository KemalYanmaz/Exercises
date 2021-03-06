using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen oyun tahtası uzunluklarını arasında boşluk bırakarak giriniz.(Örnek \"5 5\")");
            string[] inputs = Console.ReadLine().Split(' ');
            int width = Convert.ToInt16(inputs[0]);
            int height = Convert.ToInt16(inputs[1]);
            int x = 0;
            int y = 0;
            do
            {
                Console.WriteLine("Lütfen başlangıç konumunu ve yönünü seçiniz. Yönler: 'N'orth, 'E'ast, 'S'outh, 'W'est\n(Örnek \"2 2 N\")");
                inputs = Console.ReadLine().Split(' ');
                x = Convert.ToInt16(inputs[0]);
                y = Convert.ToInt16(inputs[1]);
            } while (x >= width || y >= height);
            Direction direction;
            switch (inputs[2])
            {
                case "N":
                    direction = new Direction(Directions.North);
                    break;
                case "E":
                    direction = new Direction(Directions.East);
                    break;
                case "W":
                    direction = new Direction(Directions.West);
                    break;
                case "S":
                    direction = new Direction(Directions.South);
                    break;
                default:
                    direction = new Direction(Directions.North);
                    break;
            }
            Game game = new Game(width, height, x, y, direction);
            game.Showboard();
            Console.WriteLine("Dönüşler: 'L'eft, 'R'ight | İleri Hareket: 'M'");
            Console.WriteLine("Örnek giriş: RMMLLMMRMLLLMM");
            while (true)
            {
                string input = Console.ReadLine();
                for (int i = 0; i < input.Length; i++)
                {
                    switch (input[i])
                    {
                        case 'L':
                            game.TurnTo(Turn.Left);
                            break;
                        case 'R':
                            game.TurnTo(Turn.Right);
                            break;
                        case 'M':
                            game.MoveForward();
                            break;
                        default:
                            break;
                    }
                }
            }


            char directionFirstDigit = game.GetPlayer().GetDirection().GetDirections().ToString()[0];
            Console.WriteLine($"({game.GetPlaceX()}, {game.GetPlaceY()}) {directionFirstDigit}");

            Console.ReadLine();
        }

        public void StartGameWith()
        {
            Console.WriteLine("Welcome the MARS ROVERS Game!");
            Console.Write("Your name: ");
            string name = Console.ReadLine();
            Direction direction = new Direction(Directions.North);
            Player player = new Player(name, direction);
            Console.WriteLine($"Welcome  {player.GetName()}!");
            Console.Write("Please enter the width of game board: ");
            int boardWidth = Convert.ToInt16(Console.ReadLine());
            Console.Write("Please enter the height of game board: ");
            int boardHeight = Convert.ToInt16(Console.ReadLine());
            Game game = new Game(boardWidth, boardHeight, player);
            game.Start();
        }
      

        

        
        
    }
}
