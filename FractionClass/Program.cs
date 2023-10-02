//#define METHODS_CHEK
//#define STRING_CHEK
#define OPERATOR_CHEK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace FractionClass
{
    
    internal class Program
    {
        static readonly string delimitr = "\n-----------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
#if METHODS_CHEK
            double value = 2.003;
            int number = 3;
            Fraction temp = new Fraction(3, 27, 13);
            temp.print();
            temp.to_proper();
            temp.print();
            temp.to_improper();
            temp.print();
            temp.to_proper();
            temp.print();
            Console.WriteLine(delimitr); 
#endif

#if STRING_CHEK
            //Ввод с клавиатуры в виде десятичной дроби и в виде дробной записи - "2.3" или "2 3/10"
            Console.Write("Enter double number: ");
            string double_number = Console.ReadLine();
            Fraction temp2 = new Fraction(double_number);
            temp2.print();
            temp2.reduce();
            temp2.print();
            Console.WriteLine(delimitr); 
#endif

#if OPERATOR_CHEK
            //Проверка операторов 
            Fraction temp3 = new Fraction(2.4);
            temp3.print();
            Console.WriteLine(delimitr);

            Console.WriteLine($"Unary plus {+temp3}");
            temp3.print();
            Console.WriteLine(delimitr);

            Console.Write($"Инкремент: {++temp3} ");
            temp3.print();
            Console.WriteLine(delimitr);

            Console.WriteLine($"Декримент {--temp3}");
            temp3.print();
            Console.WriteLine(delimitr);

            //temp3.to_proper();
            /*            Console.WriteLine($"Unary minus {-temp3}");
                        temp3.print();
                        Console.WriteLine(delimitr);*/

            Fraction temp4 = new Fraction(2.6);
            Console.WriteLine("Умножение дробей:");
            Fraction temp5 = temp3 * temp4;
            temp5.print();
            temp3.print();
            temp4.print();
            Console.WriteLine(delimitr);

            Console.WriteLine("деление дробей:");
            temp5 = temp3 / temp4;
            temp5.print();
            Console.WriteLine(delimitr);

            Console.WriteLine("Сложение дробей:");
            temp3 = new Fraction("2 2/5");
            temp4 = new Fraction("3 3/4");
            (temp3 + temp4).print();
            temp3.print();
            temp4.print();
            Console.WriteLine(delimitr);

            Console.WriteLine("Сравнение дробей:");
            temp3 = new Fraction("2/5");
            temp4 = new Fraction("4/10");
            Console.WriteLine(temp3 == temp4);
            Console.WriteLine(temp3 != temp4);
            Console.WriteLine(temp3 > temp4);
            Console.WriteLine(temp3 < temp4);
            Console.WriteLine(temp3 >= temp4);
            Console.WriteLine(temp3 <= temp4); 
#endif





        }
    }
}
