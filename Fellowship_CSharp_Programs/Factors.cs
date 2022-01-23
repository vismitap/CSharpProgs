using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs
{
    public class Factors
    {
        int num, flag;
        public void Factor()
        {
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int i, isPrime;

            for (i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = 1;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = 0;
                            return;
                        }
                    }

                    if (isPrime == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
