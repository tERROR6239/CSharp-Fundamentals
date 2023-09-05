using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _00.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] textAsCharArray = new char[] { 'a', 'b', 'c', };
            string text = new string(textAsCharArray); //abc
            string text2 = new string('a', 10);  //10*a
            Console.WriteLine(text);
            Console.WriteLine(text2);

            string text3 = text + "a";
            Console.WriteLine(text3);

            List<int> numbers = new List<int>() { 1, 2, 3, };
            List<int> numbers2 = numbers;
            numbers2.Add(1000);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(string.Join(" ", numbers2));

            string text4 = "abcdefgh hgfedcba";
            char charAtIndex = text4[2];
            Console.WriteLine(charAtIndex);

            string result = string.Concat(text4, text3); //събираме стрингове
            Console.WriteLine(result);

            int firstCharD = text4.IndexOf("d", 0); //намира индеьа на първото срещнато съвпадение, 
            int firstCharZ = text4.IndexOf("z", 0); //втория параметър е откой индекс да започне
            int firstCharCD = text4.IndexOf("cd", 0);
            Console.WriteLine(firstCharD);
            Console.WriteLine(firstCharZ);
            Console.WriteLine(firstCharCD);
            int lastIndexOf = text4.LastIndexOf("d", 16); //намира индекс отзад напред,
            Console.WriteLine(lastIndexOf);               //тука пак можем да му кажем от къде да започне
            bool isConteins = text4.Contains("cd", StringComparison.CurrentCultureIgnoreCase);  //проверява дали стринга съдъжа ..., 
            Console.WriteLine(isConteins); //вторият параметър в случая игнорира големи и малки букви

            string textPart = text4.Substring(0, 5); //извлича стринг от стинг 
            string filter = "fed";
            string textPart2 = text4.Substring(text4.IndexOf(filter), filter.Length); //намира парче стеринг и го извлича

            string text5 = "Hello, john@softuni.bg, you have been using john@softuni.bg in your registration";
            string[] words = text5.Split(new char[] { ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            text5 = text5.Replace("softuni.bg", "gmail.com");
            Console.WriteLine(text5);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                //text += text;  //Out of Memory
                sb.Append(text);  //добавя към стринга
            }
            sb.Clear(); //изчиства стринга
            sb.AppendLine(text); //добавя към стринга и мести на нов ред
            sb[2] = '@'; //замества символ на определено място в стринга
            sb.Insert(4, "ghjk"); //добавя символи в стринга
            sb.Replace("ghjk", string.Empty); //замества част от стринг с друга
            Console.WriteLine(sb);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            string swText = "";
            for (int i = 0; i < 100000; i++)
                swText += i;
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Stopwatch swSb = new Stopwatch();
            swSb.Start();
            StringBuilder swTextSb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
                swTextSb.Append(i);
            swSb.Stop();
            Console.WriteLine(swSb.ElapsedMilliseconds);


        char a = "a";
            char.IsNumber(a);
            char.IsDigit(a);
            char.IsLetter(a);
            char.IsLetterOrDigit(a);


        }

    }
}
