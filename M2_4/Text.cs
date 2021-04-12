using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace M2_4
{
    public class Text
    {
        public static string GetString(string stringFirst, string stringSecond)
        {
            if (Regex.IsMatch(stringFirst, @"^[a-zA-Z]+$")&& Regex.IsMatch(stringSecond, @"^[a-zA-Z]+$"))
            {
                string resultingString = null;

                foreach (var item in stringFirst.ToList().Concat(stringSecond).ToList().Distinct().ToList())
                {
                    resultingString += item;
                }

                return resultingString;
            }
            else
            {
                return "Текст введен некорректно";
            }
        }
    }
}
