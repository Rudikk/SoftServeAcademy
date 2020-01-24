using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"^(0x([0-7]|[A-F]){2}|[01]?\d?\d|2[0-5]{2})."+
                @"(0x([0-7]|[A-F]){2}|[01]?\d?\d|2[0-5]{2})."+
                @"(0x([0-7]|[A-F]){2}|[01]?\d?\d|2[0-5]{2})."+
                @"(0x([0-7]|[A-F]){2}|[01]?\d?\d|2[0-5]{2})$";

            var test = new StringBuilder();
            test.Append("99.198.122.146\n");
            test.Append("0xFF.255.138.0x12\n");
            test.Append("0xAF.125.198.0x10\n");
            test.Append("192.255.108.0x09\n");
            test.Append("256.256.256.256\n");
            Console.WriteLine("Correct IPv4 adress");
            foreach (var match in Regex.Matches(test.ToString(), pattern, RegexOptions.Multiline))
            {
                Console.WriteLine(match);
            }
        }
    }
}
