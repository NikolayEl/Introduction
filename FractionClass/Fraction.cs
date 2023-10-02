using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Value

namespace FractionClass
{
    internal class Fraction
    {
        private int integer;
        private int numerator;
        private int denominator;

        public int Integer
        {
            get;
            set;
        }
        public int Numerator
        {
            get;
            set;
        }
        public int Denominator
        {
            get { return denominator; }
            set {   
                    if (value == 0) value = 1;
                    denominator = value; 
                }
        }
        //----------------------------------Constructors-------------------------------
        public Fraction()
        {
            this.Integer = 0;
            this.Numerator = 0;
            this.Denominator = 1;
            Console.WriteLine($"DefaultConstructor:\t {this.GetHashCode()}");
        }
        public Fraction(int integer, int numerator, int denominator)
        {
            this.Integer = integer;
            this.Numerator = numerator; 
            this.Denominator = denominator;
            Console.WriteLine($"3ArgConstructor:\t {this.GetHashCode()}");
        }
        public Fraction (int numerator, int denominator)
        {
            this.Integer = 0;
            this.Numerator = numerator;
            this.Denominator = denominator;
            Console.WriteLine($"Constructor:\t\t {this.GetHashCode()}");
        }

        public Fraction(int value)
        {
            this.Integer = value;
            this.Numerator = 0;
            this.Denominator = 1;
            Console.WriteLine($"1ArgConstruction:\t {this.GetHashCode()}");
        }

        public Fraction(double value)
        {
            this.Integer = (int)value;
            string[] substrings = value.ToString().Split('.');
            int count_after = substrings[1].Length;
            this.Denominator = 1;
            for (int i = 0; i < count_after; i++) { Denominator *= 10; }
            this.Numerator = Convert.ToInt32(substrings[1]);
            this.reduce();
            Console.WriteLine($"DoubleConstruction:\t {this.GetHashCode()}");
        }
        public Fraction(string str)
        {
            if (str.Contains("."))
            {
                Integer = (int)Convert.ToDouble(str);
                string[] substrings = Convert.ToDouble(str).ToString().Split('.');
                int count_after = substrings[1].Length;
                this.Denominator = 1;
                for (int i = 0; i < count_after; i++) { Denominator *= 10; }
                this.Numerator = Convert.ToInt32(substrings[1]);
            }
            else
            {
                Integer = 0;
                if (str.Contains(" "))
                {
                    string[] substrings = str.Split(' ');
                    this.Integer = Convert.ToInt32(substrings[0]);
                    str = substrings[1];
                }
                if (str.Contains("/"))
                {
                    string[] substrings = str.Split('/');
                    this.Numerator = Convert.ToInt32(substrings[0]);
                    this.Denominator = Convert.ToInt32(substrings[1]);
                }
            }
            Console.WriteLine($"StringConstruction:\t {this.GetHashCode()}");
        }

        public Fraction(Fraction other)
        {
            this.Integer = other.Integer;
            this.Numerator = other.Numerator;
            this.Denominator = other.Denominator;
            Console.WriteLine($"CopyConstructor:\t {this.GetHashCode()}");
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor:\t\t {this.GetHashCode()}");
        }

        //----------------------------------Operator's-----------------------------
        public static Fraction operator +(Fraction other) => other;
        public static Fraction operator -(Fraction other)
        {
            if (other.Integer != 0) other.Integer = -other.Integer;
            else other.Numerator = -other.Numerator;
            return new Fraction(other.Integer, other.Numerator, other.Denominator);
        }

        public static Fraction operator +(Fraction left, Fraction right) => new Fraction(left.Integer + right.Integer,
            left.Numerator * right.Denominator + right.Numerator * left.Denominator, left.Denominator * right.Denominator).toProper().reduce();

        public static Fraction operator -(Fraction left, Fraction right) => new Fraction(left.Integer - right.Integer,
    left.Numerator * right.Denominator - right.Numerator * left.Denominator, left.Denominator * right.Denominator).toProper().reduce();

        public static Fraction operator ++(Fraction other) => new Fraction(++other.Integer, other.Numerator, other.Denominator);

        public static Fraction operator --(Fraction other) => new Fraction(--other.Integer, other.Numerator, other.Denominator);

        public static Fraction operator *(Fraction left, Fraction right)
        {
            Fraction temp_left = new Fraction(left);
            Fraction temp_right = new Fraction(right);
            temp_left.toImproper();
            temp_right.toImproper();
            return new Fraction(temp_left.Numerator * temp_right.Numerator, temp_left.Denominator * temp_right.Denominator).toProper().reduce();
        }

        public static Fraction operator /(Fraction left, Fraction right) => (left * right.inverted()).toProper().reduce();

        public static bool operator ==(Fraction left, Fraction right)
        {
            Fraction temp_left = new Fraction(left);
            Fraction temp_right = new Fraction(right);
            temp_left.toImproper();
            temp_right.toImproper();
            return (temp_left.Numerator * temp_right.Denominator == temp_right.Numerator * temp_left.Denominator);
        }
        public static bool operator !=(Fraction left, Fraction right) => !(left == right);

        public static bool operator <=(Fraction left, Fraction right)
        {
            Fraction temp_left = new Fraction(left);
            Fraction temp_right = new Fraction(right);
            temp_left.toImproper();
            temp_right.toImproper();
            return (temp_left.Numerator * temp_right.Denominator <= temp_right.Numerator * temp_left.Denominator);
        }
        public static bool operator >=(Fraction left, Fraction right)
        {
            Fraction temp_left = new Fraction(left);
            Fraction temp_right = new Fraction(right);
            temp_left.toImproper();
            temp_right.toImproper();
            return (temp_left.Numerator * temp_right.Denominator >= temp_right.Numerator * temp_left.Denominator);
        }
        public static bool operator <(Fraction left, Fraction right) => !(left >= right);
        public static bool operator >(Fraction left, Fraction right) => !(left <= right);

        //----------------------------------Method's-------------------------------

        public Fraction toProper()
        {
            if (Numerator == 0) return this;
            if (Denominator == 1)
            {
                Integer += numerator;
                Numerator = 0;
                return this;
            }
            if (Numerator >= Denominator)
            {
                Integer += (Numerator / Denominator);
                Numerator -= (Numerator / Denominator) * Denominator;
            }
            return this;
        }

        public Fraction toImproper()
        {
            if (Numerator == 0) return this;
            Numerator += (Denominator * Integer);
            Integer = 0;
            return this;
        }
        public Fraction reduce()
        {
            this.toProper();
            if (Numerator == 0) return this;
            if (Denominator == 1) return this;
            int min = Numerator, max = Denominator, temp;
            while (max != min)
            {
                max = max - min;
                if (max < min)
                { temp = min; min = max; max = temp; }
            }
            Numerator /= min;
            Denominator /= min;
            return this;
        }

        public Fraction inverted()
        {
            Fraction inverted = new Fraction(this);
            inverted.toImproper();
            (inverted.Numerator, inverted.Denominator) = (inverted.Denominator, inverted.Numerator);
            return inverted;
        }

        public void print()
        {
            Console.WriteLine((Integer == 0 ? "" : $"{Integer}(") + (Numerator == 0 ? "" : $"{Numerator}/") +
                (Numerator == 0 ? "" : $"{Denominator}") + (Integer == 0 ? "" : ")"));
        }
        public override string ToString() => ((Integer == 0 ? "" : $"{Integer}(") + (Numerator == 0 ? "" : $"{Numerator}/") +
                (Numerator == 0 ? "" : $"{Denominator}") + (Integer == 0 ? "" : ")"));
        //string output = "";
        // if (ineger != 0) output += integer.ToString();
        //return output;

    }
}
