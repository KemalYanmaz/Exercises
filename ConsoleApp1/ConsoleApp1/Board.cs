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
            FillArea();
            _area[x, y] = 'X';
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
            /*
             * for (int i = 0; i < _area.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < _area.GetLength(1); j++)
                {
                    Console.Write($"\t{_area[i, j]}");
                }
            }*/
            Console.WriteLine("------------------------------");
            for (int i = _area.GetLength(1)-1; i >= 0 ; i--)
            {
                Console.WriteLine();
                for (int j = 0; j < _area.GetLength(0); j++)
                {
                    Console.Write($"\t{_area[j, i]}");
                    //Console.WriteLine(i+","+j);
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");

        }
    }

}
