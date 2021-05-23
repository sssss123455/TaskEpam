using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace M7_2
{
    public class TitleCase
    {
        public static string GetTitleCase(string text)
        {
            var textInfo = new CultureInfo("en-En").TextInfo;
            var finishedText = textInfo.ToTitleCase(textInfo.ToLower(text));
            return finishedText;
        }
        public static string GetTitleCase(string helperText,string text)
        {
            string finishedText = null;
            var textInfo = new CultureInfo("en-En").TextInfo;
            helperText = textInfo.ToLower(helperText);
            text = textInfo.ToLower(text);
            string[] helperWords = helperText.Split(" ");
            string[] words = text.Split(" ");
            words[0] = textInfo.ToTitleCase(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                if (helperWords.FirstOrDefault(x=>x==words[i])==null)
                {
                    words[i] = textInfo.ToTitleCase(words[i]);
                }
            }
            foreach (var item in words)
            {
                finishedText += item + " ";
            }
            Console.WriteLine(finishedText);
            return finishedText;
        }
    }
}
