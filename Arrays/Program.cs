using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        //FILLRAND
        private static void fillrand(int[] arr)
        {
            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++) arr[i] = rand.Next(100, 200);
        }

        private static void fillrand(double[] arr)
        {
            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++) arr[i] = (double)rand.Next(100, 200) / 100;
        }

        private static void fillrand(char[] arr)
        {
            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++) arr[i] = (char)rand.Next(100, 200) ;
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
        private static void fillrand(double[,] i_arr_2)
        {
            Random rand = new Random(0);
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    i_arr_2[i, j] = (double)rand.Next(100) / 100;
                }
            }
        }
        private static void fillrand(char[,] i_arr_2)
        {
            Random rand = new Random(0);
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    i_arr_2[i, j] = (char)rand.Next(100);
                }
            }
        }
        //------------------------------------------------
        //PRINT
        private static void print<T>(T[] arr)
        {
            foreach(T i in arr) Console.Write(i + "\t");
        }

        private static void print<T>(T[,] i_arr_2)
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

        private static void print<T>(T[][] jagged_array)
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

        private static void print<T>(T[][,] jagged_arr_2)
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
        //--------------------------------------------------
        //SUM
        private static int sum(int[] arr)
        {
            return arr.Sum();
        }

        private static double sum(double[] arr)
        {
            return arr.Sum();
        }

        private static int sum(char[] arr)
        {
            int summa = 0;
            foreach (char c in arr) summa += c;
            return summa;
        }

        private static int sum(int[,] i_arr_2)
        {
            int sum_i_arr_2 = 0;
            foreach (int i in i_arr_2) { sum_i_arr_2 += i; }
            return sum_i_arr_2;
        }

        private static double sum(double[,] i_arr_2)
        {
            double sum_i_arr_2 = 0;
            foreach (double i in i_arr_2) { sum_i_arr_2 += i; }
            return sum_i_arr_2;
        }

        private static int sum(char[,] i_arr_2)
        {
            int sum_i_arr_2 = 0;
            foreach (int i in i_arr_2) { sum_i_arr_2 += i; }
            return sum_i_arr_2;
        }

        private static int sum(int[][] jagged_array)
        {
            int sum_jagged_array = 0;
            for (int i = 0; i < jagged_array.Length; i++) sum_jagged_array += jagged_array[i].Sum();
            return sum_jagged_array;
        }

        private static double sum(double[][] jagged_array)
        {
            double sum_jagged_array = 0;
            for (int i = 0; i < jagged_array.Length; i++) sum_jagged_array += jagged_array[i].Sum();
            return sum_jagged_array;
        }

        private static int sum(char[][] jagged_array)
        {
            int sum_jagged_array = 0;
            for (int i = 0; i < jagged_array.Length; i++) foreach(char j in jagged_array[i]) sum_jagged_array += j;
            return sum_jagged_array;
        }

        private static int sum(int[][,] jagged_arr_2)
        {
            int sum_jagged_arr_2 = 0;
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (int j in jagged_arr_2[i]) sum_jagged_arr_2 += j;
            return sum_jagged_arr_2;
        }

        private static double sum(double[][,] jagged_arr_2)
        {
            double sum_jagged_arr_2 = 0;
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (int j in jagged_arr_2[i]) sum_jagged_arr_2 += j;
            return sum_jagged_arr_2;
        }

        private static int sum(char[][,] jagged_arr_2)
        {
            int sum_jagged_arr_2 = 0;
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (int j in jagged_arr_2[i]) sum_jagged_arr_2 += j;
            return sum_jagged_arr_2;
        }
        //--------------------------------------------------
        //COUNT
        private static int count<T>(T[] arr)
        {
            int count = 0;
            foreach (T i in arr) count++;
            return count;
        }


        private static int count<T>(T[,] i_arr_2)
        {
            int number_i_arr_2 = 0;
            foreach (T i in i_arr_2) { number_i_arr_2++; }
            return number_i_arr_2;
        }

        private static int count<T>(T[][] jagged_array)
        {
            int number_jagged_array = 0;
            for (int i = 0; i < jagged_array.Length; i++) number_jagged_array += jagged_array[i].Count();
            return number_jagged_array;
        }

        private static int count<T>(T[][,] jagged_arr_2)
        {
            int number_jagged_arr_2 = 0;
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (T j in jagged_arr_2[i]) ++number_jagged_arr_2;
            return number_jagged_arr_2;
        }
        //--------------------------------------------------
        //AVERAGE
        private static double average(int[] arr)
        {
            return (double)sum(arr) / count(arr);
        }

        private static double average(double[] arr)
        {
            return (double)sum(arr) / count(arr);
        }

        private static double average(char[] arr)
        {
            return (double)sum(arr) / count(arr);
        }

        private static double average(int[,] i_arr_2)
        {
            return (double)(sum(i_arr_2)) / count(i_arr_2);
        }
        private static double average(double[,] i_arr_2)
        {
            return (double)(sum(i_arr_2)) / count(i_arr_2);
        }
        private static double average(char[,] i_arr_2)
        {
            return (double)(sum(i_arr_2)) / count(i_arr_2);
        }
        private static double average(int[][] jagged_array)
        {
            return (double)sum(jagged_array) / count(jagged_array);
        }
        private static double average(double[][] jagged_array)
        {
            return (double)sum(jagged_array) / count(jagged_array);
        }
        private static double average(char[][] jagged_array)
        {
            return (double)sum(jagged_array) / count(jagged_array);
        }

        private static double average(int[][,] jagged_arr_2)
        {
            return (double)(sum(jagged_arr_2)) / count(jagged_arr_2);
        }
        private static double average(double[][,] jagged_arr_2)
        {
            return (double)(sum(jagged_arr_2)) / count(jagged_arr_2);
        }
        private static double average(char[][,] jagged_arr_2)
        {
            return (double)(sum(jagged_arr_2)) / count(jagged_arr_2);
        }
        //--------------------------------------------------
        //MIN
        private static T min<T>(T[] arr)
        {

            return arr.Min();
        }


        private static int min(int[,] i_arr_2)
        {
            int min_i_arr_2 = i_arr_2[0, 0];
            foreach (int i in i_arr_2) { if (min_i_arr_2 > i) min_i_arr_2 = i; }
            return min_i_arr_2;
        }
        private static double min(double[,] i_arr_2)
        {
            double min_i_arr_2 = i_arr_2[0, 0];
            foreach (double i in i_arr_2) { if (min_i_arr_2 > i) min_i_arr_2 = i; }
            return min_i_arr_2;
        }
        private static char min(char[,] i_arr_2)
        {
            char min_i_arr_2 = i_arr_2[0, 0];
            foreach (char i in i_arr_2) { if (min_i_arr_2 > i) min_i_arr_2 = i; }
            return min_i_arr_2;
        }
        private static int min(int[][] jagged_array)
        {
            int min_jagged_array = jagged_array[0].Min();
            for (int i = 0; i < jagged_array.Length; i++) { if (min_jagged_array > jagged_array[i].Min()) min_jagged_array = jagged_array[i].Min(); }
            return min_jagged_array;
        }
        private static double min(double[][] jagged_array)
        {
            double min_jagged_array = jagged_array[0].Min();
            for (int i = 0; i < jagged_array.Length; i++) { if (min_jagged_array > jagged_array[i].Min()) min_jagged_array = jagged_array[i].Min(); }
            return min_jagged_array;
        }
        private static char min(char[][] jagged_array)
        {
            char min_jagged_array = jagged_array[0].Min();
            for (int i = 0; i < jagged_array.Length; i++) { if (min_jagged_array > jagged_array[i].Min()) min_jagged_array = jagged_array[i].Min(); }
            return min_jagged_array;
        }

        private static int min(int[][,] jagged_arr_2)
        {
            int min_jagged_arr_2 = jagged_arr_2[0][0, 0];
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (int j in jagged_arr_2[i])
                {
                    if (min_jagged_arr_2 > j) min_jagged_arr_2 = j;
                }
            return min_jagged_arr_2;
        }
        private static double min(double[][,] jagged_arr_2)
        {
            double min_jagged_arr_2 = jagged_arr_2[0][0, 0];
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (double j in jagged_arr_2[i])
                {
                    if (min_jagged_arr_2 > j) min_jagged_arr_2 = j;
                }
            return min_jagged_arr_2;
        }
        private static char min(char[][,] jagged_arr_2)
        {
            char min_jagged_arr_2 = jagged_arr_2[0][0, 0];
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (char j in jagged_arr_2[i])
                {
                    if (min_jagged_arr_2 > j) min_jagged_arr_2 = j;
                }
            return min_jagged_arr_2;
        }
        //--------------------------------------------------
        //MAX
        private static T max<T>(T[] arr)
        {
            return arr.Max();
        }

        private static int max(int[,] i_arr_2)
        {
            int max_i_arr_2 = i_arr_2[0, 0];
            foreach (int i in i_arr_2) { if (max_i_arr_2 < i) max_i_arr_2 = i; }
            return max_i_arr_2;
        }
        private static double max(double[,] i_arr_2)
        {
            double max_i_arr_2 = i_arr_2[0, 0];
            foreach (double i in i_arr_2) { if (max_i_arr_2 < i) max_i_arr_2 = i; }
            return max_i_arr_2;
        }
        private static char max(char[,] i_arr_2)
        {
            char max_i_arr_2 = i_arr_2[0, 0];
            foreach (char i in i_arr_2) { if (max_i_arr_2 < i) max_i_arr_2 = i; }
            return max_i_arr_2;
        }
        private static int max(int[][] jagged_array)
        {
            int max_jagged_array = jagged_array[0].Max();
            for (int i = 0; i < jagged_array.Length; i++) { if (max_jagged_array < jagged_array[i].Max()) max_jagged_array = jagged_array[i].Max(); }
            return max_jagged_array;
        }
        private static double max(double[][] jagged_array)
        {
            double max_jagged_array = jagged_array[0].Max();
            for (int i = 0; i < jagged_array.Length; i++) { if (max_jagged_array < jagged_array[i].Max()) max_jagged_array = jagged_array[i].Max(); }
            return max_jagged_array;
        }
        private static char max(char[][] jagged_array)
        {
            char max_jagged_array = jagged_array[0].Max();
            for (int i = 0; i < jagged_array.Length; i++) { if (max_jagged_array < jagged_array[i].Max()) max_jagged_array = jagged_array[i].Max(); }
            return max_jagged_array;
        }
        private static int max(int[][,] jagged_arr_2)
        {
            int max_jagged_arr_2 = jagged_arr_2[0][0, 0];
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (int j in jagged_arr_2[i])
                {
                    if (max_jagged_arr_2 < j) max_jagged_arr_2 = j;
                }
            return max_jagged_arr_2;
        }
        private static double max(double[][,] jagged_arr_2)
        {
            double max_jagged_arr_2 = jagged_arr_2[0][0, 0];
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (double j in jagged_arr_2[i])
                {
                    if (max_jagged_arr_2 < j) max_jagged_arr_2 = j;
                }
            return max_jagged_arr_2;
        }
        private static char max(char[][,] jagged_arr_2)
        {
            char max_jagged_arr_2 = jagged_arr_2[0][0, 0];
            for (int i = 0; i < jagged_arr_2.Length; i++) foreach (char j in jagged_arr_2[i])
                {
                    if (max_jagged_arr_2 < j) max_jagged_arr_2 = j;
                }
            return max_jagged_arr_2;
        }
        //--------------------------------------------------
        static readonly string delimitr = "\n-----------------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
            Console.Write("Enter size array: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 5;
            double[] arr = new double[n];
            fillrand(arr);
            Console.WriteLine("PRINT ARR:");
            print(arr);
            Console.WriteLine(delimitr);

            //Console.Write("Enter number of line: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number of row elements: ");
            // int cols = Convert.ToInt32(Console.ReadLine());
            int rows = 4, cols = 3;
            //char[,] i_arr_2 = new char[rows, cols];
            double[,] i_arr_2 = new double[rows, cols];
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
                //i_arr_2,
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
            //--------------------------------------------------------------------
            //ARR

            Console.WriteLine("ARR:");
            //SUM
            Console.WriteLine("Sum of elements to arr = " + sum(arr));

            //COUNT
            Console.WriteLine("Number of elements in the arr = " + count(arr));

            //AVERAGE
            Console.WriteLine("Average of elements in the arr = " + average(arr));

            //MIN_VALUE
            Console.WriteLine("Minimum value in arr = " + min(arr));

            //MAX_VALUE
            Console.WriteLine("Maximum value in arr = " + max(arr));
            Console.WriteLine(delimitr);
            //---------------------------------------------------------------------
            //I_ARR_2

            Console.WriteLine("I_ARR_2:");
            //SUM
            Console.WriteLine("Sum of elements to i_arr_2 = " + sum(i_arr_2));

            //COUNT
            Console.WriteLine("Number of elements in the i_arr_2 = " + count(i_arr_2));

            //AVERAGE
            Console.WriteLine("Average of elements in the i_arr_2 = " + average(i_arr_2));

            //MIN_VALUE
            Console.WriteLine("Minimum value in i_arr_2 = " + min(i_arr_2));

            //MAX_VALUE
            Console.WriteLine("Maximum value in i_arr_2 = " + max(i_arr_2));
            Console.WriteLine(delimitr);
            //---------------------------------------------------------------------
            //JUGGED_ARRAY

            Console.WriteLine("JUGGED_ARRAY:");
            //SUM
            Console.WriteLine("Sum of elements to jagged_array = " + sum(jagged_array));

            //COUNT
            Console.WriteLine("Number of elements in the jagged_array = " + count(jagged_array));

            //AVERAGE
            Console.WriteLine("Average of elements in the jagged_array = " +average(jagged_array));

            //MIN_VALUE
            Console.WriteLine("Minimum value in jagged_array = " +min(jagged_array));

            //MAX_VALUE
            Console.WriteLine("Maximum value in jagged_array = " + max(jagged_array));
            Console.WriteLine(delimitr);
            //---------------------------------------------------------------------
            //JUGGED_ARR_2

            Console.WriteLine("JUGGED_ARR_2:");
            //SUM
            Console.WriteLine("Sum of elements to jagged_arr_2 = " + sum(jagged_arr_2));

            //COUNT
            Console.WriteLine("Number of elements in the jagged_arr_2 = " + count(jagged_arr_2));

            //AVERAGE
            Console.WriteLine("Average of elements in the jagged_arr_2 = " + average(jagged_arr_2));

            //MIN_VALUE
            Console.WriteLine("Minimum value in jagged_arr_2 = " + min(jagged_arr_2));

            //MAX_VALUE
            Console.WriteLine("Maximum value in jagged_arr_2 = " + max(jagged_arr_2));
            Console.WriteLine(delimitr);
        }
    }
}
