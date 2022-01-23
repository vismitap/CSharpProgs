using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs
{
	public class CoinFlip
	{
		public void CalCoinFlipPerecnt()
		{
			Console.WriteLine("Enter your number of times to flip coin: ");
			int num = Convert.ToInt32(Console.ReadLine());
			var random = new Random();
			int noOfHeads = 0;
			int noOfTails = 0;
			int tot = num;

			while (num > 0)
			{
				double test = 0;
				test = random.NextDouble();
				Console.WriteLine(test);
				if (test < 0.5)
				{
					noOfTails++;
				}
				else
				{
					noOfHeads++;
				}

				num--;
			}
			double percentHead = ((double)noOfHeads / tot) * 100;
			double percentTail = 100 - percentHead;
			Console.WriteLine("Percentage of Head is : " + percentHead + "\nPercentage of Tail is : " + percentTail);



		}
	}
}
