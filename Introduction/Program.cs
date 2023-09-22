//#define CONSOLE_SETTINGS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {
        const string delimiter = "\n------------------------------------------------\n";
        static void Main(string[] args)
        {

#if CONSOLE_SETTINGS
            //Console.WindowLeft = -10;
            //Console.WindowTop = 10;
            Console.Title = "Itrodaction to .NET";

            int start_x = 10;
            int start_y = 10;
            //Console.Beep(37, 2000);
            int width = 120;
            int height = 32;

            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            //Console.SetWindowPosition(start_x, start_y);

            Console.WriteLine("Buffer width:\t" + Console.BufferWidth);
            Console.WriteLine("Buffer height:\t" + Console.BufferHeight);
            Console.WriteLine(delimiter);
            Console.WriteLine("Window width:\t" + Console.WindowWidth);
            Console.WriteLine("Window height:\t" + Console.WindowHeight);

            //Console.WriteLine

            Console.Write("Hello .NET");
            Console.WriteLine();

            //Console.SetCursorPosition(20, 10);
            Console.CursorLeft = 50;
            Console.CursorTop = 8;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cursor position chek");

            Console.SetCursorPosition(25, 7);
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cursor position chek2");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ResetColor();

            //Console.SetCursorPosition(0, 0);
            //Console.WriteLine("Finita la comedia");  
#endif
            Console.Write("Enter you first name: ");
            string first_name = Console.ReadLine();

            Console.Write("Enter you last name: ");
            string last_name = Console.ReadLine();

            Console.Write("Enter you age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //1) Конкатенация строк
            Console.WriteLine("First name: " + first_name + ", last name: " + last_name + ", age: " + age + " years.");

            //2) Форматирование строк
            Console.WriteLine(string.Format("First name: {0}, last name: {1}, age: {2} years", first_name, last_name, age));

            //3) Интерполяция строк
            Console.WriteLine($"First name: {first_name}, last name: {last_name}, age: {age} years");
            Console.WriteLine($"First name: {{first_name}}, last name: {last_name}, age: {age} years");
        }
    }
}
