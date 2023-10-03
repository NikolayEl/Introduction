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
        private double DEFAULT_CONSUMPTION_PER_SECOND;
        private double consumptionPerSecond;
        private bool isStarted;

        public double Consumption
        { get; set; }

        public double ConsumptionPerSecond
        { get { return consumptionPerSecond; } }

        public void setConsumptionPerSecond(int speed)
        {
            if (speed == 0) consumptionPerSecond = DEFAULT_CONSUMPTION_PER_SECOND;
            else if (speed < 60) consumptionPerSecond = DEFAULT_CONSUMPTION_PER_SECOND * 20 / 3;
            else if (speed < 100 && speed >= 60) consumptionPerSecond = DEFAULT_CONSUMPTION_PER_SECOND * 14 / 3;
            else if (speed < 140 && speed >= 100) consumptionPerSecond = DEFAULT_CONSUMPTION_PER_SECOND * 20 / 3;
            else if (speed < 200 && speed >= 140) consumptionPerSecond = DEFAULT_CONSUMPTION_PER_SECOND * 25 / 3;
            else if (speed > 200) consumptionPerSecond = DEFAULT_CONSUMPTION_PER_SECOND * 10;
        }

        public void start(){ isStarted = true; }
        public void stop(){ isStarted = false;}
        public bool started(){ return isStarted; }

        public Engine (double defaultConsumptionPerSecond) 
        { 
            DEFAULT_CONSUMPTION = defaultConsumptionPerSecond < MinEngineConsumption? MinEngineConsumption: 
                defaultConsumptionPerSecond > MaxEngineConsumption? MaxEngineConsumption: defaultConsumptionPerSecond;
            DEFAULT_CONSUMPTION_PER_SECOND = DEFAULT_CONSUMPTION * 3e-5;
            setConsumptionPerSecond(0);
            isStarted = false;
            Console.WriteLine($"Engine is ready:\t {this.GetHashCode()}");
        }
        Engine (Engine other)
        {
            Consumption = other.Consumption;
            Console.WriteLine($"CopyConstructor:\t {this.GetHashCode()}");
        }
        ~Engine() { Console.WriteLine($"Engine is stop:\t {this.GetHashCode()}"); }

        public void info()
        {
            Console.WriteLine($"Consumption:\t {Consumption} liter per 100km.");
            Console.WriteLine($"Consumption:\t {ConsumptionPerSecond} liters per 1 second.");
        }
    }
}
