using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            float totalMoney = 0f;
            float pricePerPerson = 0f;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45f;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80f;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46f;
                            break;
                    }

                    totalMoney = peopleCount * pricePerPerson;

                    if (peopleCount >= 30)
                    {
                        totalMoney = totalMoney - totalMoney * 15 / 100;
                    }

                    break;

                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.90f;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60f;
                            break;
                        case "Sunday":
                            pricePerPerson = 16f;
                            break;
                    }                    

                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }

                    totalMoney = peopleCount * pricePerPerson;

                    break;

                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15f;
                            break;
                        case "Saturday":
                            pricePerPerson = 20f;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50f;
                            break;
                    }

                    totalMoney = peopleCount * pricePerPerson;

                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalMoney = totalMoney - totalMoney * 5 / 100;
                    }  
                    
                    break;

            }
            Console.WriteLine($"Total price: {totalMoney:F2}");
        }
    }
}