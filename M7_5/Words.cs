using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace M7_5
{
    public class Words
    {
        public static string ReverseWords(string words)
        {
            string reverseWords = null;
            string[] arrayWords = words.Split(" ");
            arrayWords=arrayWords.Reverse().ToArray();
            reverseWords = string.Join(" ", arrayWords);
            //foreach (var item in arrayWords)
            //{
            //    reverseWords += item + " ";
            //}
            return reverseWords;
        }
    }
}
