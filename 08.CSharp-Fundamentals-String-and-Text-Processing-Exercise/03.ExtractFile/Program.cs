using System;

namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = string.Empty;
            string extension = string.Empty;

            string filePath = Console.ReadLine();

            int lastSeparatorIndex = filePath.LastIndexOf('\\');
            int extensionIndex = filePath.LastIndexOf('.');

            if (lastSeparatorIndex != -1 && extensionIndex != -1 && extensionIndex > lastSeparatorIndex) 
            {
                fileName = filePath.Substring(lastSeparatorIndex + 1, extensionIndex - lastSeparatorIndex - 1);
                extension = filePath.Substring(extensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
