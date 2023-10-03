using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Engine
    {
        private const int MinEngineConsumption = 3;
        private const int MaxEngineConsumption = 30;
        private double DEFAULT_CONSUMPTION;
        private double consumption;
        private double consumptionPerSecond;
        private bool isStarted;

        public double Consumption
        { get; set; }

        public double ConsumptionPerSecond
        { get; set; }

        public void start(){ isStarted = true; }
        public void stop(){ isStarted = false;}
        public bool started(){ return isStarted; }

        Engine (double consumption) 
        { 
            DEFAULT_CONSUMPTION = consumption < MinEngineConsumption? MinEngineConsumption: 
                consumption > MaxEngineConsumption? MaxEngineConsumption: Consumption;
            Consumption = DEFAULT_CONSUMPTION;
            ConsumptionPerSecond = consumption;
            isStarted = false;
            Console.WriteLine($"Engine is ready:\t {this.GetHashCode()}");
        }
        ~Engine() { Console.WriteLine($"Engine is stop:\t {this.GetHashCode()}"); }

        public void info()
        {
            Console.WriteLine($"Consumption:\t {Consumption} liter per 100km.");
            Console.WriteLine($"Consumption:\t {ConsumptionPerSecond} liters per 1 second.");
        }
    }
}
