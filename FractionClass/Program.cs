using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FractionClass
{
    class Fraction
    {
        private int integer;
        private int numerator;
        private int denominator;

        //----------------------------------Get method's-------------------------------
        public int getInteger() { return integer; }
        public int getNumerator() { return numerator; }
        public int getDenominator() { return denominator; }

        //----------------------------------Set method's-------------------------------
        public void setInteger(int value) { integer = value; }
        public void setNumerator(int value) { numerator = value; }
        public void setDenominator(int value) { denominator = value; }

        //----------------------------------Constructors-------------------------------
        public Fraction()
        {
            this.integer = 0;
            this.numerator = 0;
            this.denominator = 1;
            Console.WriteLine($"DefaultConstruction:\t {this}");
        }
        public Fraction(int integer, int numerator, int denominator) 
        {
            this.integer = integer;
            this.numerator = numerator;
            this.denominator = denominator;
            Console.WriteLine($"Construction:\t {this}");
        }

        public Fraction(int value)
        { integer = value;
            this.numerator = 0;
            this.denominator = 1;
            Console.WriteLine($"1ArgConstruction:\t {this}");
        }

        public Fraction(double value)
        {
            this.integer = (int)value;
            string[] substrings = value.ToString().Split('.');
            int count_after = substrings[1].Length;
            this.denominator = 1;
            for (int i = 0; i < count_after; i++) { denominator *= 10; }
            this.numerator = Convert.ToInt32(substrings[1]);
            Console.WriteLine($"DoubleConstruction:\t {this}");
        }
        public Fraction(string str)
        {
            if (str.Contains("."))
            {
                this.integer = (int)Convert.ToDouble(str);
                string[] substrings = Convert.ToDouble(str).ToString().Split('.');
                int count_after = substrings[1].Length;
                this.denominator = 1;
                for (int i = 0; i < count_after; i++) { denominator *= 10; }
                this.numerator = Convert.ToInt32(substrings[1]);
            }
            else
            {
                this.integer = 0;
                if (str.Contains(" "))
                {
                    string[] substrings = str.Split(' ');
                    this.integer = Convert.ToInt32(substrings[0]);
                    str = substrings[1];
                }
                if (str.Contains("/"))
                {
                    string[] substrings = str.Split('/');
                    this.numerator = Convert.ToInt32(substrings[0]);
                    this.denominator = Convert.ToInt32(substrings[1]);
                }
            }
            Console.WriteLine($"StringConstruction:\t {this}");
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor {this}");
        }

        //----------------------------------Method's-------------------------------

        public Fraction to_proper()
        {
            if (numerator == 0) return this;
            if (denominator == 1)
            {
                integer += numerator;
                numerator = 0;
                return this;
            }
            if(numerator >= denominator)
            {
                integer += (numerator / denominator);
                numerator -= (numerator / denominator) * denominator;
            }
            return this;
        }

        public Fraction to_improper()
        {
            if (numerator == 0) return this;
            numerator += (denominator * integer);
            integer = 0;
            return this;
        }
        public Fraction reduce()
        {
            this.to_proper();
            if(numerator == 0) return this;
            if(denominator == 1) return this;
            int min = numerator, max = denominator, temp;
            while (max != min)
            {
                max = max - min;
                if (max < min)
                { temp = min; min = max; max = temp; }
            }
            numerator /= min;
            denominator /= min;
            return this;
        }

        public void print()
        {
            Console.WriteLine((integer == 0 ? "":$"{integer}(") + (numerator == 0 ? "" : $"{numerator}/") + 
                (numerator == 0 ? "" : $"{denominator}") + (integer == 0 ? "" : ")")) ;
        }

    }
    internal class Program
    {
        static readonly string delimitr = "\n-----------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
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

            //Ввод с клавиатуры в виде десятичной дроби и в виде дробной записи - "2.3" или "2 3/10"
            Console.Write("Enter double number: ");
            string double_number = Console.ReadLine();
            Fraction temp2 = new Fraction(double_number);
            temp2.print();
            temp2.reduce();
            temp2.print();
            Console.WriteLine(delimitr);

            //
        }
    }
}
