using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(.*\r?\n)(\1*)";

            string toReplace= "1$\n";

            var test = new StringBuilder();
            test.Append("First list item\n");
            test.Append("First list item\n");
            test.Append("Second list item\n");
            test.Append("Second list item\n");
            test.Append("Repeated list item\n");
            test.Append("Repeated list item\n");

            Regex regex = new Regex(pattern);
            string result = regex.Replace(test.ToString(), toReplace);

            Console.WriteLine(result);
        }
    }
}
