using System;

namespace AlgoHW2
{
    internal class Program
    {
        private static long[,] dp = new long[500, 500];

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter N (5<N<500):");
            int N = Convert.ToInt32(Console.ReadLine());
            dp[N, 0] = Solve(N, 0);
            Console.WriteLine(dp[N, 0] - 1);
            Console.ReadKey();
        }

        private static long Solve(int n, int last)
        {
            if (dp[n, last] > 0)
            {
                return Program.dp[n, last];
            }
            if (n == 0)
            {
                return 1;
            }
            int num = 1;
            while (true)
            {
                if (n - num - last > last + num)
                {
                    dp[n, last] += Solve(n - num - last, last + num);
                    ++num;
                }
                else
                    break;
            }
            ++dp[n, last];
            return dp[n, last];
        }
    }
}