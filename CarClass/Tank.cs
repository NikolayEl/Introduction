using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Tank
    {
        public const int MinTankVolume = 20;
        public const int MaxTankVolume = 120;
        private int VOLUME;
        private double fuel_level;

        public double Fuel_level
        { get; set; }
        public int Volume
        { get { return VOLUME; } }

        public void fill(double fuel)
        {
            if (fuel < 0) return;
            if (Fuel_level + fuel < Volume) Fuel_level += fuel;
            else Fuel_level = Volume;
        }
        public double giveFuel(double amount)
        {
            Fuel_level -= amount;
            if (Fuel_level < 0) Fuel_level = 0;
            return Fuel_level;
        }

        public Tank(int volume)
        {
            VOLUME = volume < MinTankVolume ? MinTankVolume : volume > MaxTankVolume ? MaxTankVolume : volume;
            Fuel_level = 0;
            Console.WriteLine($"Tank is ready\t {this.GetHashCode()}");
        }
        ~Tank() { Console.WriteLine($"Tank is over\t {this.GetHashCode()}"); }

        public void info ()
        {
            Console.WriteLine($"volume:\t {Volume} liters");
            Console.WriteLine($"Fuel level:\t {Fuel_level} liters");
        }
    }
}
