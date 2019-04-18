using System;

namespace Two_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s1 = "hello";
            string s2 = "world";
            string x = twoStrings(s1, s2);
            Console.WriteLine(x);

            s1 = "hi";
            s2 = "workd";
            x = twoStrings(s1, s2);
            Console.WriteLine(x);
        }

        static string twoStrings(string s1, string s2)
        {
            string r = "NO";

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
