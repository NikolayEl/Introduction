//#define TASK_ONE
//#define TASK_TWO
#define TASK_THREE
#define TASK_FOUR
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
        private static void ConvertToMany(decimal number)
        {
            int rubl = (int)(number);
            int kopecks = (int)((number - rubl) * 100);
            Console.WriteLine($"{rubl} грн. {(kopecks < 10 ? $"0{kopecks}" : $"{kopecks}")} коп.");
        }
        static readonly string delimitr = "\n-----------------------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
            Console.Title = "Tasks Convert";

#if TASK_ONE
            //Task 1
            Console.WriteLine("Task 1");
            //1) При помощи разбития без конвертации
            Console.Write("Enter double number: ");
            string double_number = Console.ReadLine();
            string[] substrings = double_number.Split(',', '.');
            Console.WriteLine($"{substrings[0]} грн. {substrings[1][0]}{(substrings[1].Length <= 1 ? "0" : $"{substrings[1][1]}")} коп.");

            //2) С помощью конвертации
            decimal number = Convert.ToDecimal(double_number);
            int rubl = (int)(number);
            int kopecks = (int)((number - rubl) * 100);
            Console.WriteLine($"{rubl} грн. {(kopecks < 10 ? $"0{kopecks}" : $"{kopecks}")} коп.");
            Console.WriteLine(delimitr);
            //------------------------------------------------------------------------------------------------------------------------------  
#endif

#if TASK_TWO
            //Task 2
            Console.WriteLine("Task 2");
            Console.WriteLine("Введите исходные данные");
            Console.Write("Цена тетради грн.: ");
            decimal notebook = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Кол-во тетрадей: ");
            int notebook_count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена карандаша грн.: ");
            decimal pencil = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Кол-во карандашей: ");
            int pencil_count = Convert.ToInt32(Console.ReadLine());
            decimal result = notebook * notebook_count + pencil * pencil_count;
            //Console.WriteLine(result);
            ConvertToMany(result);
            Console.WriteLine(delimitr);
            //-------------------------------------------------------------------------------------------------------------------------------  
#endif

#if TASK_THREE
            //Task 3
            Console.WriteLine("Task 3"); 

#endif


        } 
    }
}
