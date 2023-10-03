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
        { get { return consumption; } }

        public double ConsumptionPerSecond
        { get; set; }

        public void start(){ isStarted = true; }
        public void stop(){ isStarted = false;}
        public bool started(){ return isStarted; }
    }
}
