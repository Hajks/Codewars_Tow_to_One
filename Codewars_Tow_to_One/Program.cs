using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Tow_to_One
{
    class Program
    {
        //##TASK DESCRIPTION##

        //Take 2 strings s1 and s2 including only letters from ato z.Return a new sorted string, the longest possible, containing distinct letters,

        //each taken only once - coming from s1 or s2. #Examples: ``` a = "xyaabbbccccdefww" b = "xxxxyyyyabklmopq" longest(a, b) -> "abcdefklmopqwxy"
        //    a = "abcdefghijklmnopqrstuvwxyz" longest(a, a)-> "abcdefghijklmnopqrstuvwxyz" ```

        static void Main(string[] args)
        {
            //MySolution
             string Longest(string s1, string s2)
            {
                return String.Concat((s1 + s2).Trim().Distinct().OrderBy(c => c));
            }

            //Codewars
            string Longest2(string s1, string s2)
            {
                return new string((s1 + s2).Distinct().OrderBy(x => x).ToArray()); //Almost the same, basicly i used Trim to delete spacebars (if they appear)
            }
        }
    }
}
