﻿using System;
namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"{Color} Seat {Model}";
            
        }
    }
}
