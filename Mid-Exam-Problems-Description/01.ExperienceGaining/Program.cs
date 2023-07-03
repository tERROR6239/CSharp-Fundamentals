using System;
using System.Timers;

namespace _01.ExperienceGaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double expNeeded = double.Parse(Console.ReadLine());
            int battelsCunt = int.Parse(Console.ReadLine());

            double expGain = 0;
            bool tankUnlock = false;
            int battlesDone = 0;

            for (int i = 1; i <= battelsCunt; i++)
            {
                double currentExp = double.Parse(Console.ReadLine());
                double bonusExp = 0;
                battlesDone++;

                if (i % 3 == 0) 
                {
                    bonusExp = currentExp * 0.15;
                    expGain += bonusExp;
                }
                else if (i % 5 == 0)
                {
                    bonusExp = currentExp * 0.10;
                    expGain -= bonusExp;
                }

                if (i % 15 == 0)
                {
                    bonusExp = currentExp * 0.15;
                    expGain += bonusExp;
                }
                
                    expGain += currentExp;

                if (expGain >= expNeeded)
                {
                    tankUnlock = true;
                    break;
                }                
            }
            if (tankUnlock) 
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battlesDone} battles.");
            }
            else 
            {
                double expToGo = expNeeded - expGain;
                Console.WriteLine($"Player was not able to collect the needed experience, {expToGo:F2} more needed.");
            }
        }
    }
}
