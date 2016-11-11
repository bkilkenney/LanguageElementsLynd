using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageElementsLynda
{
    class Program
    {
        static void Main(string[] args)
        {

            //ConcatTwoStrings("First string ", "and this is the second/last string");

            //string sentence = ConcatTwoStrings("First part of the string", " and last part of the string");
            Console.WriteLine(ConcatTwoStrings("First part of the string", " and last part of the string"));
            Console.ReadLine();

            //This way works but the writeline can go in the method's code block keeping Main more clean
            Console.WriteLine(Add(270, 218));
            Console.ReadLine();

            //Check out how clean this code looks
            Sum(3, 5);
            Console.ReadLine();
        }

        static string ConcatTwoStrings(string str1, string str2)
        {
            string fullString = str1 + str2;
            return fullString;            
        }

        static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        static void Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
       

    }
}
