﻿using System;
namespace TheRace
{
    public class Car
    { 
        public string Name { get; set; }
        public int Speed { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
