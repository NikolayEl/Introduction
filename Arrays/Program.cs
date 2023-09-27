﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random(0);
            for(int i = 0; i < arr.Length; i++) arr[i] = rand.Next(100, 200);
            for(int i = 0; i < arr.Length; i++) Console.Write(arr[i] + "\t");
            Console.WriteLine();

            foreach(int i in arr) Console.Write(i + "\t");
            Console.WriteLine();

        }
    }
}