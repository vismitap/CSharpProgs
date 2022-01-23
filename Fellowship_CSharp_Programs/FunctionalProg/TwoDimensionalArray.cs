using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs.FunctionalProg
{
    public class TwoDimensionalArray
    {
        int row, column, i , j;
        public void Matrix()
        {
            Console.WriteLine("Enter the value of Row and Column: ");
            row = Convert.ToInt32(Console.ReadLine());
            column = Convert.ToInt32(Console.ReadLine());

            int [,] arr = new int[row, column];

            Console.WriteLine("Enter the elements: ");
            for(i = 0; i < row; i++)
            {
                for(j = 0; j < column; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The Matrix is : ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < column; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
