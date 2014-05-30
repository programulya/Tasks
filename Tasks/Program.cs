using System;
using System.Linq;

namespace Tasks
{
    internal class Program
    {
        private static void Main()
        {
            // Find number of occurrences of symbol
            const string str = "Mama mila ramu";
            var count = str.ToLower().Count(c => c == 'm');
            Console.WriteLine(count);

            // Get the right order of words in string
            const string news = "An unmanned aerial vehicle (UAV) that was shot down" +
                                " on May 28 in the area of the anti-terrorist operation " +
                                "(ATO) was produced in Russia, the press center of the " +
                                "Security Service of Ukraine (SBU)";

            var words = new[] {"Russia", "center", "Ukraine", "an", "on", "of"};

            var dictionary = words.ToDictionary(w => w, w => news.IndexOf(w, StringComparison.Ordinal))
                .OrderBy(w => w.Value);

            foreach (var d in dictionary)
            {
                Console.WriteLine(d);
            }
        }
    }
}