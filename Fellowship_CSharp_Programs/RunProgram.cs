using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs
{
    public class RunProgram
    {
        public void PrintHello(string name)
        {
            Console.WriteLine("Hello I am " + name);
        }

        public string StringReverse(string str)
        {

            char[] strArr = str.ToCharArray();
            Array.Reverse(strArr);
            Console.WriteLine("Orginal string: " + str + " \nReversed String: " + new string(strArr));
            return new string(strArr);
        }

        public void CheckPalindrome(string str)
        {
            string text = str;
            string revText = StringReverse(str);
            if (text == revText)
            {
                Console.WriteLine($"The string {str} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"The string {str} is NOT a Palindrome");
            }
        }
        public void ReplaceText()
        {
            string text = "I am in the bootcamp batch.";
            string outputText = text.Replace("bootcamp", "Fellowship");
            Console.WriteLine(outputText);
        }

        public void AddNum(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
        }

    }

}
