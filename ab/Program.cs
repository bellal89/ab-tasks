using System;

namespace ab
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLuckysAmount(j / 2));
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
