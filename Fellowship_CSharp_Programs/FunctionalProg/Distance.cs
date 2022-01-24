using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs.FunctionalProg
{
    public class Distance
    {
        public void CalDist()
        {
            Console.Write("Enter x co-ordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y co-ordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double dist = Math.Sqrt(x*x + y*y);
            Console.WriteLine($"The distance of ({x},{y}) from (0,0) is: "+dist);
        }
    }
}
