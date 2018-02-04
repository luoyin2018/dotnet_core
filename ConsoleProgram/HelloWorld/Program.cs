using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Do you like net core?
                            This the first example.
                            Do you know me?
                            This is LuoYin.";

            Dictionary<string,int> frequencies = CountWords(text);

            foreach(KeyValuePair<string,int> entry in frequencies)
            {
                Console.WriteLine("{0}:{1}",entry.Key,entry.Value);
            }

            Console.WriteLine("Hello World!");
        }

        static Dictionary<string,int> CountWords(string text)
        {
            Dictionary<string,int> frequencies = new Dictionary<string,int>();

            string[] words = Regex.Split(text,@"\W+");
            
            foreach(string word in words)
            {
                if(frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word]=1;
                }
            }
            return frequencies;
        }
    }
}
