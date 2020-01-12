using System;
using System.Collections.Generic;

namespace AlgoHW
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter N (0<N<110):");
            int N = Convert.ToInt32(Console.ReadLine());
            int num = Solve(N);
            Console.WriteLine($"{N} - {num}");
            Console.ReadKey();
        }

        private static int Parse(List<int> list)
        {
            string str = "";
            foreach (int num in list)
                str += num.ToString();
            return Convert.ToInt32(str);
        }

        private static int Solve(int n)
        {
            List<int> list = new List<int>();
            if (n < 10)
                return n;
            for (int index = 9; index >= 2; --index)
            {
                while (n % index == 0)
                {
                    n /= index;
                    list.Add(index);
                }
            }
            if (n > 10)
                return -1;
            list.Sort();
            return Parse(list);
        }
    }
}
