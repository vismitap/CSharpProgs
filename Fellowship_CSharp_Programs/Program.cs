using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n*********************************");
                Console.WriteLine("Enter \n" +
                    "0: EXIT \n"+
                    "1: Printing Hello \n" +
                    "2: Checking Palindrome \n" +
                    "3: Replacing Text \n" +
                    "4: Adding Numbers \n" +
                    "5: Reversing a String \n" +
                    "6. String Replace \n"+
                    "7: Leap Year \n" +
                    "8: Coin Flip \n" +
                    "9: Power of 2 \n" +
                    "10: Harmonic Number \n" +
                    "11: Factors \n");

                Console.WriteLine("Enter your option: ");
                int op = Convert.ToInt32(Console.ReadLine());

                RunProgram prog = new RunProgram();
                StringReplace stringReplace =  new StringReplace();
                LeapYear lp = new LeapYear();
                CoinFlip cf = new CoinFlip();
                pow2 pow = new pow2();
                HarmonicNumber harmonic = new HarmonicNumber();
                Factors factors = new Factors();

                switch (op)
                {
                    case 0:
                        flag = false;
                        break;

                    case 1:
                        prog.PrintHello("Vismita");
                        break;

                    case 2:
                        prog.CheckPalindrome("Java");
                        break;

                    case 3:
                        prog.ReplaceText();
                        break;

                    case 4:
                        prog.AddNum(20, 100);
                        break;

                    case 5:
                        Console.WriteLine("Enter a string: ");
                        string str = Console.ReadLine();
                        prog.StringReverse(str);
                        break;

                    case 6:
                        stringReplace.StringRep();
                        break;

                    case 7:
                        lp.IsLeapYear();
                        break;

                    case 8:
                        cf.CalCoinFlipPerecnt();
                        break;

                    case 9:
                        pow.CalPow2();
                        break;

                    case 10:
                        harmonic.CalHarmonicNo();
                        break;

                    case 11:
                        factors.Factor();
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("*********************************\n");
            }


        }
    }
}
