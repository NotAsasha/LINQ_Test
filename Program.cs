using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void FirstTask(List<string> _strings)
            {
                var resWords = _strings.Where(s => !string.IsNullOrEmpty(s) && char.IsUpper(s[0])).Distinct();
                Console.WriteLine("\n---All the words from task 1:\n");
                foreach (var word in resWords) Console.WriteLine(word);
            }
            void SecondTask(List<int> _ints)
            {
                int sum = _ints.Where(num => num % 3 == 0 || num % 5 == 0).Sum();
                Console.WriteLine("\n---Sum from task 2:\n"); // 3,6,9,5
                Console.WriteLine(sum);
            }
            void ThirdTask(List<string> _strings)
            {
                var sumOfStrings = _strings.Select(s => s + "!!!");
                Console.WriteLine("\n---Result from task 3:\n");
                foreach (var word in sumOfStrings) Console.WriteLine(word);
            }
            void ForthTask(List<int> _years)
            {
                var leapYears = _years.Where(y => y % 4 == 0).OrderBy(y => y);
                Console.WriteLine("\n---All the years from task 4:\n");
                foreach (var year in leapYears) Console.WriteLine(year);
            }

            List<string> strings = new List<string> { "word", "BIGWORD", "_strange_word", "", "Yes", "Yes", "sssss" };
            FirstTask(strings);

            List<int> ints = new List<int>();
            for (int i = 0; i < 10; i++) ints.Add(i);
            SecondTask(ints);

            List<string> strings2 = new List<string> { "So", "it" , "should" , "work", };
            ThirdTask(strings2);

            List<int> years = new List<int>();
            for (int i = 2025; i > 2000; i--) years.Add(i);
            ForthTask(years);
        }
    }
}
