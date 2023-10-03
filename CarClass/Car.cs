using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Car
    {
        private const int MaxSpeedLowerLevel = 30;
        private const int MaxSpeedUpperLevel = 400;
        private Engine engine;
        private Tank tank;
        private int speed;
        private int MAX_SPEED;
        private bool driverInside;
        private bool isMove;
        public Thread panelThread;
        public Thread engineIdleThread;
        public Thread freeWheelingThread;


        public int Speed {  get; set; }
        public int MaxSpeed { get; set; }
        public bool DriverInside { get; set; }
        public bool IsMove { get; set; }

        public Car(double consumption, int volume, int maxSpeed)
        {
            engine = new Engine(consumption);
            tank = new Tank(volume);
            MaxSpeed = maxSpeed < MaxSpeedLowerLevel? MaxSpeedLowerLevel : maxSpeed > MaxSpeedUpperLevel? MaxSpeedUpperLevel: maxSpeed;
            DriverInside = false;
            IsMove = false;
            Thread.CurrentThread.Name = "mainThread";
            Console.WriteLine($"Your car is ready to go {this.GetHashCode()}");
        }
        ~Car() { Console.WriteLine($"Car is over:\t {this.GetHashCode()}"); }

        public void getIn()
        {
            DriverInside = true;
            panelThread = new Thread(panel);
            panelThread.Start();
            Console.WriteLine("Inside");
        }
        public void getOut()
        {
            DriverInside = false;
            if (panelThread.IsBackground = true) panelThread.Abort();
            Console.Clear();
            Console.WriteLine("Outside");

        }
        public void start()
        {
            if(DriverInside && tank.Fuel_level > 0)
            {
                Speed = 0;
                engine.start();
                engineIdleThread = new Thread(engile_idle);
                engineIdleThread.Start();
            }
        }
        public void stop()
        {
            engine.stop();
            if(engineIdleThread.IsBackground = true)engineIdleThread.Abort();
            Console.WriteLine(Thread.CurrentThread.Name);
        }
        public void panel()
        {
            while(DriverInside)
            {
                Console.Clear();
                Console.Write($"Level fuel:\t {tank.Fuel_level} liters");
                Console.WriteLine(tank.Fuel_level <= 5 ? "\t\t LOW FUEL" : "");
                Console.WriteLine($"Engine is:\t {(engine.started() == true ? "started" : "stopped")}");
                Console.WriteLine($"Speed:\t {(isMove == true ? Speed : 0)}");
                Console.WriteLine($"ConsumptionPerSecond:\t {engine.ConsumptionPerSecond} liters.");
                Thread.Sleep(200);
            }


        }
        public void engile_idle()
        {
            while (engine.started() && tank.Fuel_level > 0) 
            {
                Thread.Sleep(600);
            }
        }
        public void freeWheeling()
        {
            while(--speed > 0)
            {
                Thread.Sleep(300);
                engine.setConsumptionPerSecond(speed);
            }
        }
        public void control()
        {
            ConsoleKeyInfo keys;
            do 
            { 
                keys = Console.ReadKey(true);
                switch(keys.Key) 
                {
                    case ConsoleKey.Enter:
                        if (DriverInside) getOut();
                        else if (!DriverInside && speed == 0) getIn();
                        break;
                    case ConsoleKey.F:
                        if (DriverInside)
                        {
                            Console.WriteLine("Для начала нужно выйти из машины");
                            Thread.Sleep(120);
                            break;
                        }
                        double fuel;
                        Console.Write("Enter volume fuel: ");
                        fuel = Convert.ToDouble(Console.ReadLine());
                        tank.fill(fuel);
                        break;
                    case ConsoleKey.I:
                        if (engine.started())
                        {
                            speed = 0;
                            stop();
                        }
                        else start();
                        break;
                    case ConsoleKey.Escape:
                        speed = 0;
                        if (engine.started()) stop();
                        getOut();
                        break;
                    default:
                        if (tank.Fuel_level == 0) stop();
                        if (speed < 1) engine.setConsumptionPerSecond(speed = 0);
                        if (speed == 0 && freeWheelingThread.IsBackground == true) freeWheelingThread.Abort();
                        break;
                }
                
            } while (keys.Key != ConsoleKey.Escape);
        }

    }

}
