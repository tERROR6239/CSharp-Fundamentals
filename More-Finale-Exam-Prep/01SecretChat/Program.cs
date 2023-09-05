using System;
using System.Linq;

namespace _01SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretMsg = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] token = command.Split(":|:").ToArray();

                switch (token[0])
                {
                    case "InsertSpace":
                        int startIndex = int.Parse(token[1]); 
                        secretMsg = secretMsg.Insert(startIndex, " ");
                        Console.WriteLine(secretMsg);
                        break;

                    case "Reverse":
                        if (secretMsg.Contains(token[1]))
                        {
                            startIndex = secretMsg.IndexOf(token[1]);
                            secretMsg = secretMsg.Remove(startIndex, token[1].Length);

                            char[] stringArray = token[1].ToCharArray();
                            Array.Reverse(stringArray);
                            string reverse = new string(stringArray);

                            secretMsg = secretMsg + reverse;
                            Console.WriteLine(secretMsg);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ChangeAll":
                        while (secretMsg.Contains(token[1]))
                        {
                            secretMsg = secretMsg.Replace(token[1], token[2]);
                            Console.WriteLine(secretMsg);
                        }
                        break;
                }
            }
            Console.WriteLine($"You have a new text message: {secretMsg}");
        }
    }
}
