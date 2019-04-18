using System;

namespace Two_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "world";
            string x = twoStrings(s1, s2);
            Console.WriteLine(x);

            s1 = "hi";
            s2 = "world";
            x = twoStrings(s1, s2);
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
                        r = "YES";
                        break;
                    }
                }

                if(r == "YES")
                {
                    break;
                }

                if(c1.Length != 1)
                {
                    y++;
                    c1 = ns.Substring(y);
                    c3 = c1.ToCharArray();
                    c2 = c3[0];
                }
            }

            return r;
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
