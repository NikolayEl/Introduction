using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Shooter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my SHOOTER!");
            Console.WriteLine("Press w - to move up,");
            Console.WriteLine("Press s - to move down,");
            Console.WriteLine("Press a - to move left,");
            Console.WriteLine("Press d - to move right,\n");
            Console.WriteLine("Press space - to jump,");
            Console.WriteLine("Press enter - to fire,\n");

            Console.WriteLine("Press q - to exit the game.\n");
            ConsoleKeyInfo keys;
            do
            {
                while (Console.KeyAvailable == false)
                    Thread.Sleep(250);

                keys = Console.ReadKey(true);
                switch(keys.Key)
                {
                    case ConsoleKey.W:
                        Console.WriteLine("UP");
                        Console.Beep(200, 250);
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("DOWN");
                        Console.Beep(200, 250);
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("LEFT");
                        Console.Beep(200, 250);
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("RIGHT");
                        Console.Beep(200, 250);
                        break;
                    case ConsoleKey.Spacebar:
                        Console.WriteLine("JUMP");
                        Console.Beep(300, 500);
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("FIRE");
                        for(int i = 0; i < 3; i++) Console.Beep(400, 40);
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("QUIT");
                        for(int i = 600; i > 100; i = i - 150) Console.Beep(i, 100);
                        break;
                }
                //Console.WriteLine($"You press {keys.Key} key");

            } while (keys.Key != ConsoleKey.Q);
        }
    }
}
