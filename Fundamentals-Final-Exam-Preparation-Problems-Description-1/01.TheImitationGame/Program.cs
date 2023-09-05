using System;

namespace _01.TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string line = string.Empty;
            while ((line = Console.ReadLine()) != "Decode")
            {
                string[] lineTokens = line.Split("|");
                string command = lineTokens[0];

                if (command == "Insert")
                {
                    int indexToInsert = int.Parse(lineTokens[1]);
                    string valueToInsert = lineTokens[2];
                    message = message.Insert(indexToInsert, valueToInsert); //string
                }
                else if (command == "ChangeAll")
                {
                    string stringToBeRaolaced = lineTokens[1];
                    string replacment = lineTokens[2];
                    message = message.Replace(stringToBeRaolaced, replacment);
                }
                else if (command == "Move")
                {
                    int countOfLetters = int.Parse(lineTokens[1]);
                    string temp = message.Substring(0, countOfLetters);
                    message = message.Remove(0, countOfLetters);
                    message = message + temp;
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
