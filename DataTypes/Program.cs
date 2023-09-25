//#define LOGICAL_TYPES
//#define CHARACTER_TYPES
//#define INTEGRAL_TYPES
#define FLOATING_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
  internal class Program
  {
    static readonly string delimiter = "\n------------------------------------------------------------------------\n";
  static void Main(string[] args)
  {

#if LOGICAL_TYPES
      Console.WriteLine("BOOL: ");
      Console.WriteLine(sizeof(bool));        //Boolean
      Console.WriteLine(true.GetType());
      Console.WriteLine((3 + 2.5).GetType());
      Console.WriteLine(delimiter);
#endif

#if CHARACTER_TYPES
      Console.WriteLine("CHAR:"); //Хранит один символ в кодировке Unicode
      Console.WriteLine(sizeof(char));
      Console.WriteLine((int)(char.MinValue));
      Console.WriteLine((int)(char.MaxValue));
      Console.WriteLine(delimiter);
#endif

#if INTEGRAL_TYPES
      Console.WriteLine("SHORT:"); //Хранит один символ в кодировке Unicode
      Console.WriteLine(sizeof(short));
      Console.WriteLine("USHORT:\t" + ushort.MinValue + "......" + ushort.MaxValue);
      Console.WriteLine("SHORT:\t" + short.MinValue + "......" + short.MaxValue);
      Console.WriteLine(delimiter);

      int temp_int = 0;
      Console.WriteLine("INT:");
      Console.WriteLine(sizeof(int));
      Console.WriteLine(temp_int.GetType());
      Console.WriteLine("UINT:\t" + uint.MinValue + "......" + uint.MaxValue);
      Console.WriteLine("INT:\t" + int.MinValue + "......" + int.MaxValue);
      Console.WriteLine(delimiter);

      long temp_long = 0;
      Console.WriteLine("LONG:");
      Console.WriteLine(sizeof(long));
      Console.WriteLine(temp_long.GetType());
      Console.WriteLine("ULONG:\t" + ulong.MinValue + "......" + ulong.MaxValue);
      Console.WriteLine("LONG:\t" + long.MinValue + "......" + long.MaxValue);
      Console.WriteLine(delimiter); 
#endif
#if FLOATING_TYPES

      Console.WriteLine("FLOAT:\t" + sizeof(float) + " Bytes");
      Console.WriteLine(float.MinValue + "....." + float.MaxValue);
      Console.WriteLine(delimiter);


      Console.WriteLine("DOUBLE:\t" + sizeof(double) + " Bytes");
      Console.WriteLine(double.MinValue + "....." + double.MaxValue);
      Console.WriteLine(delimiter);

      Console.WriteLine("DECIMAL:\t" + sizeof(decimal) + " Bytes");
      Console.WriteLine(decimal.MinValue + "....." + decimal.MaxValue);
      Console.WriteLine(delimiter);
#endif

    }
  }
}
