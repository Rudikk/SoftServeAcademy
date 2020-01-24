using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern=@"(^1\d{3}|200\d|201[0-2])/(0\d|1[0-2])/([0-2]\d|30)\s([0-1]\d|2[0-4]):([0-5]\d|60)$";
            var test = new StringBuilder();
            test.Append("2012/09/18 12:10\n");
            test.Append("2010/08/12 11:05\n");
            test.Append("999/01/12 12:15\n");
            test.Append("2012/09/18 14:25\n");
            test.Append("1000/01/01 07:01\n");
            test.Append("2013/11/15 15:15\n");

            Console.WriteLine("Dates in range between 1000 and 2012 years");
            foreach (var match in Regex.Matches(test.ToString(), pattern, RegexOptions.Multiline))
            {
                Console.WriteLine(match);
            }
        }
    }
}
                                        