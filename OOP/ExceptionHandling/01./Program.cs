﻿using System;

namespace _01_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                double b = Math.Sqrt(a);
                Console.WriteLine(b);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
            
        }
    }
}
