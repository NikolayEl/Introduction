using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ChessBoard";

            Console.Write("Enter chessboard size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            bool exam = false;
            for (int i = 0; i < size *2 + 2; i++) Console.Write('-');
            Console.WriteLine();
            Console.Write("|");
            for (int i = 0, j = 0; j < size * size; i++)
            {
                if (!exam && size % 2 == 0) Console.BackgroundColor = ConsoleColor.White;
                else Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("  ");
                j++;
                if (j % size == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write('|');
                    if (j == size * size) break;
                    Console.WriteLine();
                    Console.Write('|');
                    if (exam) exam = false;
                    else exam = true;
                }
                if (!exam && size % 2 == 0) Console.BackgroundColor = ConsoleColor.Black;
                else Console.BackgroundColor = ConsoleColor.White;
                Console.Write("  ");
                j++;
                if (j % size == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write('|');
                    if (j == size * size) break;
                    Console.WriteLine();
                    Console.Write('|');
                    if (exam) exam = false;
                    else exam = true;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            for (int i = 0; i < size * 2 + 2; i++) Console.Write('-');
            Console.WriteLine();
        }
    }
}
