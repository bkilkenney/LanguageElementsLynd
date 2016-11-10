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

            string mySentence = ConcatTwoStrings("First string and ", "last string.");
            Console.WriteLine(mySentence);
        }

        static string ConcatTwoStrings(string str1, string str2)
        {
            string fullString = str1 + str2;
            return fullString;            
        }


    }
}
