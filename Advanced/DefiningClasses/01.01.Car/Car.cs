﻿using System;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make - "VW"
            Model - "Golf"


        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            var fuelToConsume = distance * FuelConsumption;

            if (FuelQuantity - fuelToConsume >= 0)
            {
                FuelQuantity -= fuelToConsume;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }

        }

        public string WhoAmI()
        {
            return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2} L";
        }
    }
}
