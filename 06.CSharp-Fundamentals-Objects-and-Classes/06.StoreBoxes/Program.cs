using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end") 
            {
                string[] tokens = input
                    .Split(' ')
                    .ToArray();
                 
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3]);

                Item item = new Item(itemName, price);
                Box box = new Box(serialNumber, item, quantity);
                boxes.Add(box);
            }
            foreach (Box box in boxes.OrderByDescending(x => x.BoxPrice)) 
            {
                Console.WriteLine($"{box.SerialNomber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }

    public class Item 
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNomber, Item item, int quantity)
        {
            SerialNomber = serialNomber;
            Item = item;
            Quantity = quantity;
        }

        public string SerialNomber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal BoxPrice
        {
            get 
            {
                return Item.Price * Quantity;
            } 
        }
        //or
        //public decimal BoxPrice => Item.Price * Quantity;
    }
}
