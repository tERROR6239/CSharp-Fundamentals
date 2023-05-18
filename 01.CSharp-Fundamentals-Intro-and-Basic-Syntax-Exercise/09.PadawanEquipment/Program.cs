using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float priceSabers = float.Parse(Console.ReadLine());
            float priceRobe = float.Parse(Console.ReadLine());
            float priceBelts = float.Parse(Console.ReadLine());

            float costSabers = 0;
            float costRobe = 0;
            float costBelts = 0;
            int extraSabers = 0;
            float totalCost = 0;

            double tenPercent = students / 10.0;
            extraSabers = (int)Math.Ceiling(tenPercent);
            costSabers = priceSabers * (students + extraSabers);

            int bonusBelts = students / 6;
            costBelts = priceBelts * (students - bonusBelts);

            costRobe = priceRobe * students;

            totalCost = costSabers + costBelts + costRobe;

            if (money >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {totalCost - money:F2}lv more.");
            }
            

        }
    }
}
