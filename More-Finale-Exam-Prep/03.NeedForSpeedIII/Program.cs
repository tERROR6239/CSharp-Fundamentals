using System;
using System.Collections.Generic;

namespace _03.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsNumber = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < carsNumber; i++)
            {
                string[] tokens = Console.ReadLine().Split("|");
                string brand = tokens[0];
                int mileage = int.Parse(tokens[1]);
                int fuel = int.Parse(tokens[2]);

                if (!cars.ContainsKey(brand))
                {
                    cars.Add(brand, new Car());
                }

                cars[brand].Brand = brand;
                cars[brand].Mileage = mileage;
                cars[brand].Fuel = fuel;
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] arguments = command.Split(" : ");
                string carBrand = arguments[1];
                switch (arguments[0])
                {
                    case "Drive":
                        int distance = int.Parse(arguments[2]);
                        int fuelNeed = int.Parse(arguments[3]);

                        if (cars[carBrand].Fuel >= fuelNeed)
                        {
                            cars[carBrand].Mileage += distance;
                            cars[carBrand].Fuel -= fuelNeed;
                            Console.WriteLine($"{carBrand} driven for {distance} kilometers. {fuelNeed} liters of fuel consumed.");
                            if (cars[carBrand].Mileage >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {carBrand}!");
                                cars.Remove(carBrand);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        break;

                    case "Refuel":
                        int fuelAdd = int.Parse(arguments[2]);
                        int fu = cars[carBrand].Fuel;

                        cars[carBrand].Fuel += fuelAdd;
                        if (cars[carBrand].Fuel > 75)
                        {
                            fuelAdd = 75 - fu;
                            cars[carBrand].Fuel = 75;
                        }
                        Console.WriteLine($"{carBrand} refueled with {fuelAdd} liters");
                        break;

                    case "Revert":
                        int kilometers = int.Parse(arguments[2]);
                        int km = cars[carBrand].Mileage;

                        cars[carBrand].Mileage -= kilometers;

                        if (cars[carBrand].Mileage < 10000)
                        {
                            kilometers = km - 10000;
                            cars[carBrand].Mileage = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{carBrand} mileage decreased by {kilometers} kilometers");
                        }
                        break;
                }
            }

            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Brand} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");                
            }
        }

        public class Car
        {
            public string Brand { get; set; }
            public int Mileage { get; set; }
            public int Fuel { get; set; }
        }
    }
}
