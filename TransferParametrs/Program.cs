using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferParametrs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            input(out a, out b);
            Console.WriteLine($"a = {a}, b = {b}");
            Exchange(ref a,ref b);
            Console.WriteLine($"a = {a}, b = {b}");
        }
        static void input(out int a,out int b)
        {
            Console.Write("Enter first a number: ");
            a = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Enter second a number: ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        static void Exchange(ref int a,ref int b)
        {
            int buffer = a;
            a = b;
            b = buffer;
        }
    }
}
