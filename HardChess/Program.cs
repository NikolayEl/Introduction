using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardChess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HardChess";
            Console.Write("Enter board size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            bool exam = true;
            for (int l = 0; l < size; l++)
            {
                for (int k = 0; k < size; k++)
                {
                    for (int j = 0; j < size ; j++)
                    {
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write((exam) ? "*" : " ");
                            if (i != size - 1) Console.Write(" ");
                        }
                        if (exam) exam = false;
                        else exam = true;
                    }
                    Console.WriteLine();
                    if (exam) exam = false;
                    else exam = true;
                }
                if (exam ) exam = false;
                else exam = true;
            }

        }
    }
}
