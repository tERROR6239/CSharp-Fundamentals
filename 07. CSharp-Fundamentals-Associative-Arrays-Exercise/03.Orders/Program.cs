using System;
using System.Collections.Generic;

namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            string product;

            while ((product = Console.ReadLine()) != "buy")
            {
                string[] arguments = product.Split();
                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                decimal quantity = decimal.Parse(arguments[2]);

                Product newProduct = new Product(name, price, quantity);

                if (!products.ContainsKey(newProduct.Name))
                {
                    products.Add(newProduct.Name, newProduct);
                    
                }
                else
                {
                    Product p = products[newProduct.Name];
                    p.Update(newProduct.Price, newProduct.Quantity);
                }
            }

            foreach (KeyValuePair<string, Product> pair in products) //обхождаме всеяка двойка(ключ - стоиност) на речника
            {
                Console.WriteLine(pair.Value);
            } 

            //or

            /*
            foreach (Product p in products.Values) //обхождаме само стойностите на речника
            {
                string result = p.ToString();
                Console.WriteLine(result);
            }
            */
        }
    }
    class Product
    {
        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public decimal TotalPrice
        {
            get { return Price * Quantity; }
        }
        public void Update(decimal price, decimal quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {TotalPrice}";
        }
    }
}
