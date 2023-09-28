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
        private static void fillrand(int[] arr)
        {
            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++) arr[i] = rand.Next(100, 200);
        }

        private static void fillrand(int[,] i_arr_2)
        {
            Random rand = new Random(0);
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    i_arr_2[i, j] = rand.Next(100);
                }
            }
        }

        private static void print(int[] arr)
        {
            foreach(int i in arr) Console.Write(i + "\t");
        }

        private static void print(int[,] i_arr_2)
        {
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void print(int[][] jagged_array)
        {
            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write(jagged_array[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void print(int[][,] jagged_arr_2)
        {
            for (int i = 0; i < jagged_arr_2.Length; i++)
            {
                for (int j = 0; j < jagged_arr_2[i].GetLength(0); j++)
                {
                    for (int k = 0; k < jagged_arr_2[i].GetLength(1); k++)
                    {
                        Console.Write(jagged_arr_2[i][j, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static readonly string delimitr = "\n-----------------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
            Console.Write("Enter size array: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 5;
            int[] arr = new int[n];
            Random rand = new Random(0);
            fillrand(arr);
            Console.WriteLine("PRINT ARR:");
            print(arr);
            Console.WriteLine(delimitr);

            //Console.Write("Enter number of line: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number of row elements: ");
            // int cols = Convert.ToInt32(Console.ReadLine());
            int rows = 4, cols = 3;
            int[,] i_arr_2 = new int[rows, cols];
            fillrand(i_arr_2);
            Console.WriteLine("PRINT I_ARR_2");
            print(i_arr_2);
            //Console.WriteLine(i_arr_2.Rank);
            //foreach(int i in i_arr_2) Console.Write(i + "\t");
            Console.WriteLine(delimitr);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int[][] jagged_array = new int[][]
            {
                new int[] {3, 5, 8, 13, 21},
                new int[] {34, 55, 89},
                new int[] {144, 233, 377, 510}
            };
            Console.WriteLine("PRINT JAGGED_ARRAY");
            print(jagged_array);
            Console.WriteLine(delimitr);
            int[][,] jagged_arr_2 = new int[][,]
            {
                i_arr_2,
                new int[,]
                {
                    {256, 384, 512, 768},
                    {1024, 2048, 3072, 4096}
                }
            };

            Console.WriteLine("PRINT JAGGED_ARR_2");
            print(jagged_arr_2);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //1) Find the sum of elements
            Console.WriteLine(delimitr);
            Console.WriteLine("SUM, AVERAGE, MIN_VALUE, MAX VALUE:");
            Console.WriteLine("ARR:");
            //SUM
            int sum_arr = arr.Sum();
            Console.WriteLine("Sum of elements to arr = " + sum_arr);

            //COUNT
            int number_arr = arr.Count();
            Console.WriteLine("Number of elements in the arr = " + number_arr);

            //AVERAGE
            double average_arr = (double)(sum_arr) / number_arr;
            Console.WriteLine("Average of elements in the arr = " + average_arr);

            //MIN_VALUE
            int min_arr = arr.Min();
            Console.WriteLine("Minimum value in arr = " + min_arr);

            //MAX_VALUE
            int max_arr = arr.Max();
            Console.WriteLine("Maximum value in arr = " + max_arr);
            Console.WriteLine(delimitr);
            //---------------------------------------------------------------------

            Console.WriteLine("I_ARR_2:");
            //SUM
            int sum_i_arr_2 = 0;
            foreach (int i in i_arr_2) { sum_i_arr_2 += i; }
            Console.WriteLine("Sum of elements to i_arr_2 = " + sum_i_arr_2);

            //COUNT
            int number_i_arr_2 = 0;
            foreach(int i in i_arr_2) {  ++number_i_arr_2; }
            Console.WriteLine("Number of elements in the i_arr_2 = " + number_i_arr_2);

            //AVERAGE
            double average_i_arr_2 = (double)(sum_i_arr_2) / number_i_arr_2;
            Console.WriteLine("Average of elements in the i_arr_2 = " + average_i_arr_2);

            //MIN_VALUE
            int min_i_arr_2 = i_arr_2[0,0];
            foreach(int i in i_arr_2) { if (min_i_arr_2 > i) min_i_arr_2 = i; }
            Console.WriteLine("Minimum value in i_arr_2 = " + min_i_arr_2);

            //MAX_VALUE
            int max_i_arr_2 = i_arr_2[0,0];
            foreach(int i in i_arr_2) { if (max_i_arr_2 < i) max_i_arr_2 = i; }
            Console.WriteLine("Maximum value in i_arr_2 = " + max_i_arr_2);
            Console.WriteLine(delimitr);
            //---------------------------------------------------------------------

            Console.WriteLine("JUGGED_ARRAY:");
            //SUM
            int sum_jagged_array = 0;
            for (int i = 0; i < jagged_array.Length; i++) sum_jagged_array += jagged_array[i].Sum();
            Console.WriteLine("Sum of elements to jagged_array = " + sum_jagged_array);

            //COUNT
            int number_jagged_array = 0;
            for (int i = 0; i < jagged_array.Length; i++) number_jagged_array += jagged_array[i].Count();
            Console.WriteLine("Number of elements in the jagged_array = " + number_jagged_array);

            //AVERAGE
            double average_jagged_array = (double)(sum_jagged_array) / number_jagged_array;
            Console.WriteLine("Average of elements in the jagged_array = " + average_jagged_array);

            //MIN_VALUE
            int min_jagged_array = jagged_array[0].Min();
            for(int i = 0; i < jagged_array.Length; i++) { if (min_jagged_array > jagged_array[i].Min()) min_jagged_array = jagged_array[i].Min(); }
            Console.WriteLine("Minimum value in jagged_array = " + min_jagged_array);

            //MAX_VALUE
            int max_jagged_array = jagged_array[0].Max();
            for (int i = 0; i < jagged_array.Length; i++) { if (max_jagged_array < jagged_array[i].Max()) max_jagged_array = jagged_array[i].Max(); }
            Console.WriteLine("Maximum value in jagged_array = " + max_jagged_array);
            Console.WriteLine(delimitr);
            //---------------------------------------------------------------------

            Console.WriteLine("JUGGED_ARR_2:");
            //SUM
            int sum_jagged_arr_2 = 0;
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach(int j in jagged_arr_2[i]) sum_jagged_arr_2 += j;
            Console.WriteLine("Sum of elements to jagged_arr_2 = " + sum_jagged_arr_2);

            //COUNT
            int number_jagged_arr_2 = 0;
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach(int j in jagged_arr_2[i]) ++number_jagged_arr_2;
            Console.WriteLine("Number of elements in the jagged_arr_2 = " + number_jagged_arr_2);

            //AVERAGE
            double average_jagged_arr_2 = (double)(sum_jagged_arr_2) / number_jagged_arr_2;
            Console.WriteLine("Average of elements in the jagged_arr_2 = " + average_jagged_arr_2);

            //MIN_VALUE
            int min_jagged_arr_2 = jagged_arr_2[0][0,0];
            for(int i = 0; i < jagged_arr_2.Length;i++) foreach(int j in jagged_arr_2[i]) 
                {
                    if (min_jagged_arr_2 > j) min_jagged_arr_2 = j;
                }
            Console.WriteLine("Minimum value in jagged_arr_2 = " + min_jagged_arr_2);

            //MAX_VALUE
            int max_jagged_arr_2 = jagged_arr_2[0][0, 0];
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (int j in jagged_arr_2[i])
                {
                    if (max_jagged_arr_2 < j) max_jagged_arr_2 = j;
                }
            Console.WriteLine("Maximum value in jagged_arr_2 = " + max_jagged_arr_2);
            Console.WriteLine(delimitr);
        }
    }
}
