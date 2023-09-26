using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksConvert
{
    internal class Program
    {
        static readonly string delimitr = "\n-----------------------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
            Console.Title = "Tasks Convert";

            //Task 1
            Console.WriteLine("Task 1");
            //1) При помощи разбития без конвертации
            Console.Write("Enter double number: ");
            string double_number = Console.ReadLine();
            string[] substrings = double_number.Split(',', '.');
            Console.WriteLine($"{substrings[0]} руб. {substrings[1][0]}{(substrings[1].Length <= 1 ? "0" : $"{substrings[1][1]}")} коп.");

            //2) С помощью конвертации
            decimal number = Convert.ToDecimal(double_number);
            int rubl = (int)(number);
            int kopecks = (int)((number - rubl) * 100);
            Console.WriteLine($"{rubl} руб. {(kopecks < 10 ? $"0{kopecks}":$"{kopecks}" )} коп.");
            Console.WriteLine(delimitr);
            //------------------------------------------------------------------------------------------------------------------------------

            //Task 2
            Console.WriteLine("Task 2");

        } 
    }
}
