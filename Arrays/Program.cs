using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static readonly string delimitr = "\n-----------------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
            Console.Write("Enter size array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random(0);
            for(int i = 0; i < arr.Length; i++) arr[i] = rand.Next(100, 200);
            for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + "\t");
            Console.WriteLine();

            foreach(int i in arr) Console.Write(i + "\t");
            Console.WriteLine();
            Console.WriteLine(delimitr);

            Console.Write("Enter number of line: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of row elements: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] i_arr_2 = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    i_arr_2[i, j] = rand.Next(100);
                }
            }
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(i_arr_2.Rank);
            foreach(int i in i_arr_2) Console.Write(i + "\t");
            Console.WriteLine();
            Console.WriteLine(delimitr);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int[][] jagged_array = new int[][]
            {
                new int[] {3, 5, 8, 13, 21},
                new int[] {34, 55, 89},
                new int[] {144, 233, 377, 510}
            };
            for(int i = 0; i < jagged_array.Length; i++)
            {
                for(int j = 0; j < jagged_array[i].Length; j++) 
                {
                    Console.Write(jagged_array[i][j] + "\t");
                }
                Console.WriteLine();
            }
            int[][,] jagged_arr_2 = new int[][,]
            {
                i_arr_2,
                new int[,]
                {
                    {256, 384, 512, 768},
                    {1024, 2048, 3072, 4096}
                }
            };
        }
    }
}
