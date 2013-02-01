using System;
using System.Diagnostics;

namespace ab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new []{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
        	var sw = new Stopwatch();
			sw.Start();
            int nAmount = NAmountWithKSum(int.Parse(input[0]), int.Parse(input[1]) / 2);
			Console.WriteLine(nAmount * nAmount);
        	sw.Stop();
			Console.WriteLine(sw.Elapsed);
            /*
             * We calculated a number of lucky tickets with 2N digits. 
             * We have to calculate a number of lucky tickets with ALL digits sum defined.
             */
        }

        private static int GetLuckysAmount(int digitsAmount)
        {
            int amount = 0;
            for (int i = 0; i <= 9 * digitsAmount; i++)
            {
                int tmp = NAmountWithKSum(digitsAmount, i);
                amount += tmp * tmp;
            }
            return amount;
        }

        private static int NAmountWithKSum(int n, int k)
        {
			if (k > 9 * n)
				return 0;
            if (n == 1)
                return 0 <= k && k <= 9 ? 1 : 0;
            int sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (i <= k)
                    sum += NAmountWithKSum(n - 1, k - i);
            }
            return sum;
        }
    }
}
