using System;
using System.Diagnostics;

namespace ab
{
	class Program
	{
		static void Main(string[] args)
		{
			var sw = new Stopwatch();
			for (var j = 2; j < 9; j += 2)
			{
				sw.Start();
				Console.WriteLine(j + ":\t" + GetLucky(j));
				sw.Stop();
				Console.WriteLine(sw.Elapsed);
				sw.Reset();
			}

			Console.ReadKey();
		}
		
		private static int GetLucky(int num)
		{
			var maxNum = ((int)Math.Pow(10, num)) - 1;
			var res = 0;
			for (var j = 0; j <= maxNum; j++)
			{
				var half1 = 0;
				var half2 = 0;
				for (var i = 0; i < num; i++)
				{
					var tmp = (j / ((int)Math.Pow(10, i))) % 10;
					if (i < num / 2)
						half1 += tmp;
					else
						half2 += tmp;
				}
				if (half1 == half2)
					res++;
			}
			return res;
		}
	}
}
