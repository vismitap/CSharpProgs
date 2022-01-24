using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs.FunctionalProg
{
    public class QuadraticRoots
    {
        public void CalRes(string equation)
        {
            string firstPart = equation.Split('+')[0].Trim();
            string a = firstPart.Split('x')[0].Trim();

            string lastPart = equation.Split('+')[1].Trim();
            string b = lastPart.Split('x')[0].Trim();
            string c = equation.Split('+')[2].Trim();

            int aVal = Convert.ToInt32(a);
            int bVal = Convert.ToInt32(b);
            int cVal = Convert.ToInt32(c);

            if(a == "")
            {
                aVal = 1; 
            }
            if (b == "") {
                bVal = 1;
            }
            if (c == "") { 
                cVal = 1;
            }

            int delta = ((bVal * bVal) - 4 * aVal * cVal);
            Console.WriteLine("Delta is: " + delta);
            int deno = 2 * aVal;
            double sqrt = Math.Sqrt(delta);
            double root1 = (-bVal + sqrt) / deno;
            double root2 = (- bVal - sqrt) / deno;

            Console.WriteLine("Root1 is : " + root1 + "\nRoot2 is : " + root2);
        }

        public void CalResDir(int aVal, int bVal, int cVal)
        {
            int delta = ((bVal * bVal) - 4 * aVal * cVal);
            int deno = 2 * aVal;
            double sqrt = Math.Sqrt(delta);
            double root1 = (-bVal + sqrt) / deno;
            double root2 = (-bVal - sqrt) / deno;

            Console.WriteLine("Root1 is : " + root1 + "\nRoot2 is : " + root2);

        }
        public void CalRoots()
        {
            //Console.WriteLine("Enter the quadratic equation: In the format (ax*x+bx+c)");
            //string equation = Console.ReadLine();
            //CalRes(equation); 

            Console.WriteLine("Enter the value a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            CalResDir(a,b,c);
        }
    }
}
