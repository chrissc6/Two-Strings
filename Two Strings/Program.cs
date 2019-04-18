using System;
using System.Linq;

namespace Two_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "world";
            string x = twoStrings2(s1, s2);
            Console.WriteLine(x);

            s1 = "hi";
            s2 = "world";
            x = twoStrings2(s1, s2);
            Console.WriteLine(x);
        }

        static string twoStrings(string s1, string s2)
        {
            string r = "NO";

            string ns = s1;
            int x = s1.Length;
            int y = 0;
            string c1 = ns.Substring(y);
            char[] c3 = c1.ToCharArray();
            char c2 = c3[0];

            for (int i = 0; i < x; i++)
            {
                foreach (var j in s2)
                {
                    if (j == c2)
                    {
                        return "YES";
                    }
                }

                if(c1.Length != 1)
                {
                    c1 = ns.Substring(++y);
                    c3 = c1.ToCharArray();
                    c2 = c3[0];
                }
            }

            return r;
        }

        static string twoStrings1(string s1, string s2)
        {
            string r = "NO";

            int x = s1.Length;
            int y = s2.Length;

            if(x>y)
            {
                foreach (var i in s1)
                {
                    foreach (var j in s2)
                    {
                        if (i == j)
                        {
                            return "YES";
                        }
                    }
                }

            }
            else
            {
                foreach (var i in s2)
                {
                    foreach (var j in s1)
                    {
                        if (i == j)
                        {
                            return "YES";
                        }
                    }
                }
            }

            return r;
        }

        static string twoStrings2(string s1, string s2)
        {
            var distS1 = s1.Distinct();
            var distS2 = s2.Distinct();

            if (distS1.Intersect(distS2).Any())
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}

/*
Given two strings, determine if they share a common substring. A substring may be as small as one character.

For example, the words "a", "and", "art" share the common substring (a).
The words "be" and "cat" do not share a substring. 

-----

Complete the function twoStrings in the editor below. It should return a string, 
either YES or NO based on whether the strings share a common substring.

twoStrings has the following parameters:
s1, s2: two strings to analyze .

*/
