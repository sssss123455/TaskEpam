using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M2_4
{
    public class String
    {
        public static string GetString(string stringFirst, string stringSecond)
        {
            string resultingString = null;
           
            foreach (var item in stringFirst.ToList().Concat(stringSecond).ToList().Distinct().ToList())
            {
               resultingString+=item;
            }
            
            return resultingString;
        }
    }
}
