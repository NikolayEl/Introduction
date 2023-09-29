using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    internal class Program
    {
        static readonly string delimiter = "\n--------------------------------------------------------\n";
        static void Main(string[] args)
        {
            DayofWeek day = DayofWeek.Friday;
            Console.WriteLine(day);
            string[] dayName = Enum.GetNames(typeof(DayofWeek));
            foreach(string name in dayName) { Console.WriteLine(name); }
            Console.WriteLine(delimiter);

            DistanceFromSun planet = DistanceFromSun.Earth;
            Console.WriteLine($"{planet} {planet.GetHashCode()}");
            string[] distNames = Enum.GetNames(typeof(DistanceFromSun));
            ulong[] distValues = (ulong[])Enum.GetValues(typeof(DistanceFromSun));
            for (int i = 0; i < distNames.Length; i++)
            {
                Console.WriteLine($"{distNames[i]}\t{distValues[i]}");
            }
            Console.WriteLine(Enum.GetUnderlyingType(typeof(DistanceFromSun)).GetType());
        }
        enum DayofWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
        enum DistanceFromSun: ulong
        {
            Sun = 0,
            Mercury = 579000,
            Venus = 108000000,
            Earth = 149600000
        };
    }
}
