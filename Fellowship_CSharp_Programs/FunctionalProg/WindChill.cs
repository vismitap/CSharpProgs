using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs.FunctionalProg
{
    public class WindChill
    {
        public void CalWindChill()
        {
            Console.WriteLine("Enter value of t (<50)");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of v (3<v<120)");
            double v = Convert.ToDouble(Console.ReadLine());

            double w = (35.74 + 0.6215 * t + 0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("The WindChill is: "+w);
        }
    }
}
