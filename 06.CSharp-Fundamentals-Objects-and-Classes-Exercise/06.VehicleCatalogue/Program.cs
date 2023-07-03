using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End") 
            {
                string[] arguments = command.Split(" ");
                string type = arguments[0];
                string model = arguments[1];
                string color = arguments[2];
                decimal hp = decimal.Parse(arguments[3]);

                Vehicle vehical = new Vehicle(type, model, color, hp);
                catalogue.Add(vehical);
            }
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle foundVehical = catalogue.Find(vehical => vehical.Model == command); //търсим дали имаме такър модел
                if (foundVehical != null)  //ако имаме го принтираме
                {
                    Console.WriteLine(foundVehical.Print());
                }

                // or
                /*
                foreach (Vehicle vehicle in catalogue) 
                {
                    if (vehicle.Model == command)
                    {
                        Console.WriteLine(vehicle.Print());
                        break;
                    }                
                }
                */

            }
                decimal averageHP = catalogue
                    .Where(vehical => vehical.Type == "Car") //селектираме всички обекти с тип "car"
                    .Select(vehicle => vehicle.HP) //взимаме само полето HP на селектираните обекти
                    .DefaultIfEmpty() //ако колекцията е празна (нямаме коли) да не гърми връща празна колекция
                    .Average(); //смятаме средната стойност на всички селектирани обекти

                Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

                averageHP = catalogue
                    .Where(vehical => vehical.Type == "Truck") //селектираме всички обекти с тип "car"
                    .Select(vehicle => vehicle.HP) //взимаме само полето HP на селектираните обекти
                    .DefaultIfEmpty() //ако колекцията е празна (нямаме камиони) да не гърми връща празна колекция
                    .Average(); //смятаме средната стойност на всички селектирани обекти

                Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");
        }
    }
}

class Vehicle    
{
    public Vehicle(string typeInput, string model, string color, decimal hp)
    {
        Type = typeInput;
        Model = model;
        Color = color;
        HP = hp;
    }

    private string type = "";

    public string Type 
    {
        get
        {
            return type;
        }
        set
        {
            type = Capitalize(value);
        }
    }
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal HP { get; set; }

    public string Capitalize(string value)
    {
        char[] charArrey = value.ToCharArray();
        if (char.IsLower(charArrey[0]))
        {
            charArrey[0] = char.ToUpper(charArrey[0]);
        }
        return new string(charArrey);
    }

    public string Print()
    {
        string result = "";

        result += $"Type: {Type}\n";
        result += $"Model: {Model}\n";
        result += $"Color: {Color}\n";
        result += $"Horsepower: {HP}";
        return result;
    }
} 