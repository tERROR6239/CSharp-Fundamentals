using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            float priceHeadset = float.Parse(Console.ReadLine());
            float priceMise = float.Parse(Console.ReadLine());
            float priceKeyboard = float.Parse(Console.ReadLine());
            float priceDisplay = float.Parse(Console.ReadLine());

            float totalCoast = 0;
            int kbTrashCount = 0;


            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0) 
                {
                    totalCoast += priceHeadset;
                }
                if (i % 3 == 0) 
                {
                    totalCoast += priceMise;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    totalCoast += priceKeyboard;
                    kbTrashCount++;
                    if (kbTrashCount == 2)
                    {
                        totalCoast += priceDisplay;
                        kbTrashCount = 0;
                    }
                }                
            }
            Console.WriteLine($"Rage expenses: {totalCoast:F2} lv.");

        }
    }
}
