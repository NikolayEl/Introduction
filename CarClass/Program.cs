using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car(10, 40, 250);
            bmw.control();
        }
    }
}
