using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionClass
{
    internal class Fraction
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
        public void setDenominator(int value) { denominator = value; if (denominator == 0) denominator = 1;  }

        //----------------------------------Constructors-------------------------------
        public Fraction()
        {
            this.integer = 0;
            this.numerator = 0;
            this.denominator = 1;
            Console.WriteLine($"DefaultConstructor:\t {this.GetHashCode()}");
        }
        public Fraction(int integer, int numerator, int denominator)
        {
            setInteger(integer);
            setNumerator(numerator); 
            setDenominator(denominator);
            Console.WriteLine($"Construction:\t {this.GetHashCode()}");
        }
        public Fraction (int numerator, int denominator)
        {
            this.integer = 0;
            setNumerator(numerator);
            setDenominator(denominator);
            Console.WriteLine($"Constructor:\t {this.GetHashCode()}");
        }

        public Fraction(int value)
        {
            this.integer = value;
            this.numerator = 0;
            this.denominator = 1;
            Console.WriteLine($"1ArgConstruction:\t {this.GetHashCode()}");
        }

        public Fraction(double value)
        {
            this.integer = (int)value;
            string[] substrings = value.ToString().Split('.');
            int count_after = substrings[1].Length;
            this.denominator = 1;
            for (int i = 0; i < count_after; i++) { denominator *= 10; }
            this.numerator = Convert.ToInt32(substrings[1]);
            Console.WriteLine($"DoubleConstruction:\t {this.GetHashCode()}");
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
            Console.WriteLine($"StringConstruction:\t {this.GetHashCode()}");
        }

        public Fraction(Fraction other)
        {
            this.integer = other.integer;
            this.numerator = other.numerator;
            this.denominator = other.denominator;
            Console.WriteLine($"CopyConstructor:\t {this.GetHashCode()}");
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor:\t {this.GetHashCode()}");
        }

        //----------------------------------Operator's-----------------------------
        public static Fraction operator +(Fraction other) => other;
        public static Fraction operator -(Fraction other)
        {
            if (other.integer != 0) other.integer = -other.integer;
            else other.numerator = -other.numerator;
            return new Fraction(other.integer, other.numerator, other.denominator);
        }

        public static Fraction operator +(Fraction left, Fraction right) => new Fraction(left.integer + right.integer,
            left.numerator * right.denominator + right.numerator * left.denominator, left.denominator * right.denominator).to_proper().reduce();

        public static Fraction operator -(Fraction left, Fraction right) => new Fraction(left.integer - right.integer,
    left.numerator * right.denominator - right.numerator * left.denominator, left.denominator * right.denominator).to_proper().reduce();

        public static Fraction operator ++(Fraction other) => new Fraction(++other.integer, other.numerator, other.denominator);

        public static Fraction operator --(Fraction other) => new Fraction(--other.integer, other.numerator, other.denominator);

        public static Fraction operator *(Fraction left, Fraction right)
        {
            left.to_improper();
            right.to_improper();
            return new Fraction(0, left.numerator * right.numerator, left.denominator * right.denominator).to_proper().reduce();

        }

        public static Fraction operator /(Fraction left, Fraction right) => (left * right.inverted()).to_proper().reduce();

        public static bool operator ==(Fraction left, Fraction right)
        {
            left.to_improper();
            right.to_improper();
            return (left.numerator * right.denominator == right.numerator * left.denominator);
        }
        public static bool operator !=(Fraction left, Fraction right) => !(left == right);

        public static bool operator <=(Fraction left, Fraction right)
        {
            left.to_improper();
            right.to_improper();
            return (left.numerator * right.denominator <= right.numerator * left.denominator);
        }
        public static bool operator >=(Fraction left, Fraction right)
        {
            left.to_improper();
            right.to_improper();
            return (left.numerator * right.denominator >= right.numerator * left.denominator);
        }
        public static bool operator <(Fraction left, Fraction right) => !(left >= right);
        public static bool operator >(Fraction left, Fraction right) => !(left <= right);

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
            if (numerator >= denominator)
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
            if (numerator == 0) return this;
            if (denominator == 1) return this;
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

        public Fraction inverted()
        {
            this.to_improper();
            int temp;
            temp = this.numerator;
            this.numerator = this.denominator;
            this.denominator = temp;
            return this;
        }

        public void print()
        {
            Console.WriteLine((integer == 0 ? "" : $"{integer}(") + (numerator == 0 ? "" : $"{numerator}/") +
                (numerator == 0 ? "" : $"{denominator}") + (integer == 0 ? "" : ")"));
        }
        public override string ToString() => ((integer == 0 ? "" : $"{integer}(") + (numerator == 0 ? "" : $"{numerator}/") +
                (numerator == 0 ? "" : $"{denominator}") + (integer == 0 ? "" : ")"));

    }
}
