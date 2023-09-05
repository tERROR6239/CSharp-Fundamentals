using System;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Done")
                break;

            string[] tokens = command.Split(' ');
            string action = tokens[0];

            if (action == "TakeOdd")
            {
                password = TakeOdd(password);
            }
            else if (action == "Cut")
            {
                int index = int.Parse(tokens[1]);
                int length = int.Parse(tokens[2]);
                password = CutPassword(password, index, length);
            }
            else if (action == "Substitute")
            {
                string substring = tokens[1];
                string substitute = tokens[2];
                password = SubstitutePassword(password, substring, substitute);
            }
        }

        Console.WriteLine("Your password is: " + password);
    }

    static string TakeOdd(string password)
    {
        string new_password = "";
        for (int i = 1; i < password.Length; i += 2)
        {
            new_password += password[i];
        }
        Console.WriteLine(new_password);
        return new_password;
    }

    static string CutPassword(string password, int index, int length)
    {
        string substring = password.Substring(index, length);
        int firstOccurrence = password.IndexOf(substring);
        if (firstOccurrence != -1)
        {
            password = password.Remove(firstOccurrence, length);
        }
        Console.WriteLine(password);
        return password;
    }

    static string SubstitutePassword(string password, string substring, string substitute)
    {
        if (password.Contains(substring))
        {
            password = password.Replace(substring, substitute);
            Console.WriteLine(password);
        }
        else
        {
            Console.WriteLine("Nothing to replace!");
        }
        return password;
    }
}
