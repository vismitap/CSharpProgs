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
        public bool IsPrime(int n)
        {
            for (int i=2; i<=n/2; i++)
            {
                if (n % i == 0)
                {
                  //Console.WriteLine("False");
                    return false;
                }
            }
           // Console.WriteLine("True");
            return true;
        }

        public void Factor()
        {
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int i;
            flag = 0;

            for ( i = 2; i <= num; i++) { }
            {
                if (num%i==0 && IsPrime(i))
                {
                    Console.WriteLine(i);
                    flag = 1;     
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("No Prime factors");
            }
        }
    }
}
