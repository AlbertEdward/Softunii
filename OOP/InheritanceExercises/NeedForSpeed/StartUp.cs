﻿using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car(10,10);

            vehicle.Drive(1);
        }
    }
}
