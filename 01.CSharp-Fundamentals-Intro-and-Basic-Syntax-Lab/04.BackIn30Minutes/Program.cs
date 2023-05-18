namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours -= 23;
            }

            Console.WriteLine("{0}:{1:D2}", hours, minutes);
            //or
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}