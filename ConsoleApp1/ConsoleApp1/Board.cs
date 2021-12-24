using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Board
    {
        private char[,] _area;
        private int _counter = 0;
        public Board(int width, int height)
        {
            _area = new char[width, height];
            FillArea();
            MarkCell(0,0);
        }

        private void FillArea()
        {
            for (int i = 0; i < _area.GetLength(0); i++)
            {
                for (int j = 0; j < _area.GetLength(1); j++)
                {
                    _area[i, j] = '-';
                }
            }
        }

        public void MarkCell(int x, int y)
        {
            
            if (x < _area.GetLength(0) && y < _area.GetLength(1))
            {
                FillArea();
                _area[x, y] = 'X';
            }
            else
            {
                Console.WriteLine("Hatali Giris");
            }
        }

        public int GetWidth()
        {
            return _area.GetLength(0);
        }

        public int GetHeight()
        {
            return _area.GetLength(1);
        }

        public void Show()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            for (int i = _area.GetLength(1)-1; i >= 0 ; i--)
            {
                for (int j = 0; j < _area.GetLength(0); j++)
                {
                    Console.Write($"\t{_area[j, i]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"----------------------------------------------{++_counter}");
            Console.WriteLine();

        }
    }

}
