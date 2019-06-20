using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a sentence that has \"not\" and \"poor\" in it");
            string givenString = Console.ReadLine();
            Console.WriteLine(GetFirstApearanceOfSubstrings(givenString));
        }

        //Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, if 'not' follows the 'poor', 
        //replace the whole 'not'...'poor' substring with 'good'. Return the resulting string.
        public static string GetFirstApearanceOfSubstrings(string input)
        {
            string result = string.Empty;
            int index1 = input.IndexOf("not");
            int index2 = input.IndexOf("poor");

            if (index1 > index2)
            {
                return result;
            }

            result = input.Substring(0, index1) + "good" + input.Substring(index2 + "poor".Length);

            return result;
        }
    }
}

