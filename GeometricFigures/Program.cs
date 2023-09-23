using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal class Program
    {
        const string delimitr = "\n---------------------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
            //0) 
            for (int i = 0; i < 5; i++)
            { 
                for (int j = 0; j < 5; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimitr);

            //1) 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimitr);

            //2)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimitr);

            //3)
            for (int i = 0; i < 5; i++)
            {
                //for (int k = 0; k < i; k++) Console.Write(" ");
                Console.CursorLeft = i;
                for (int j = 5; j > i; j--) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine(delimitr);

            //4) 
            for (int i = 0; i < 5; i++)
            {
                //for (int k = 5; k > i; k--) Console.Write(" "); //1) Вариант с помощью цикла
                Console.CursorLeft = 4 - i; //Второй вариант с помощью позиции курсора
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
            Console.WriteLine(delimitr);

            //5) 
            for(int i = 0; i < 5; i++)
            {
                Console.CursorLeft = 4 - i;
                Console.Write("/");
                Console.CursorLeft = 5 + i;
                Console.Write('\\');
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.CursorLeft = i;
                Console.Write("\\");
                Console.CursorLeft = 9 - i;
                Console.Write('/');
                Console.WriteLine();
            }
            Console.WriteLine(delimitr);

            //6) 
            for(int i = 0, j = 0; j < 45; i ++)
            {
                Console.Write('+');
                j++;
                if (j % 9 == 0) Console.WriteLine();
                else
                {
                    Console.Write(' ');
                    j++;
                }
                if (j == 45) break;
                Console.Write('-');
                j++;
                if (j % 9 == 0) Console.WriteLine();
                else
                {
                    Console.Write(' ');
                    j++;
                }
            }
            Console.WriteLine(delimitr);

        }
    }
}
