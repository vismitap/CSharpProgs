using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs.FunctionalProg
{
    public class SumThreeEqualsZero
    {
        public void CalTriplets()
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int [] arr = new int[n];
            int count = 0;

            Console.WriteLine($"Enter {n} elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < n-2; i++)
            {
                for (int j = i+1; j < n-1; j++)
                {
                    for(int k = i+2; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0 && i!=j && j!=k && i!=k)
                        {
                            //Console.WriteLine(arr[i]+ " + " + arr[j]+ " + "+ arr[k]);
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine("The Count of triplets having sum 0 is: "+count);
        }
    }
}
