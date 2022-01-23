using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs
{
    public class HarmonicNumber
    {
        public void CalHarmonicNo()
        {
            Console.WriteLine("Enter a number N: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double ans = 0;
            if (num != 0)
            {
                for (int i = 1; i <= num; i++)
                {
                     ans += ((double)1 / i);
                }
            }
            else
            {
                Console.WriteLine("The number should be > 0");
            }

            Console.WriteLine(ans);
        }

    }
}
