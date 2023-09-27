using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  internal class Program
  {
        static void Main(string[] args)
        {
            Console.Title = "CALCULATOR";
            Console.Write("Enter expression: ");

            string expression = Console.ReadLine();
            string sign = expression;
            string[] substrings;
            //Console.WriteLine(expression.IndexOf("+"));

            //Распилил строку по делимитру
            substrings = expression.Split('+', '-', '*', '/');

            //Перебор получившихся значений и удаление их из строки, пока не останется только знак выражения
            foreach (string substring in substrings)
            {
                sign = sign.Replace(substring, "");
            }

            //Проверка на наличие указанного знака и на кол-во знаков
            if(sign == "" || sign.Length > 1)
            {
                Console.WriteLine("Не найден знак выражения или их больше одного.");
                return;
            }

            //Double потому что могу ввести и int и double
            double expression_left;
            double expression_right;

            //Добавил проверку исключений, потому что могут ввести все что угодно
            try
            {
                expression_left = Convert.ToDouble(substrings[0]);
                expression_right = Convert.ToDouble(substrings[1]);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Одно или оба значения не являются числами");
                return;
            }
            double result = 0;

            switch (sign)
            {
                case "+":
                    result = expression_left + expression_right;
                    break;
                case "-":
                    result = expression_left - expression_right;
                    break;
                case "*":
                    result = expression_left * expression_right;
                    break;
                case "/":
                    Convert.ToDouble(result);
                    result = expression_left / expression_right;
                    break;
                default:
                    Console.WriteLine("Неправильный знак или неврно записано выражение!");
                    break;
            }
            Console.WriteLine($"{expression} = {result}");
            //Console.WriteLine(substrings.Length);
        }
        
  }
}
