using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs
{
    public class pow2
    {
        public void CalPow2()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            long pow=1;
            for (int i=1; i<=num; i++) {
                pow *= 2; 
            }

            Console.WriteLine($"2^{num} = "+pow);
            
        }
    }
}
