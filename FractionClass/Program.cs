using System;
using System.Collections.Generic;
using System.Linq;
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
        public int getNumerator() { return numerator;}
        public int getDenominator() { return denominator;}

        //----------------------------------Set method's-------------------------------
        public void setInteger(int value) { integer = value; }
        public void setNumerator(int value) { numerator = value; }
        public void setDenominator(int value) {  denominator = value; }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
