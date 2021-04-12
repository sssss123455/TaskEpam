using System;
using System.Collections.Generic;
using System.Linq;

namespace M2_5
{
    public class Number
    {
        public static long FindNextBiggerNumber(int number)
        {
            bool flag = false;
            char[] num = number.ToString().ToArray();
            List<char> helpList = new List<char>();
            int newnumber = 0;
            int begin = num.Count() - 1;
            char numHelp;
            string text = null;
            for (int i = begin; i > -1; i--)
            {
                for (int j = begin; j > -1; j--)
                {
                    if (i < j && num[i] < num[j])
                    {
                        numHelp = num[i];
                        num[i] = num[j];
                        num[j] = numHelp;
                        flag = true;
                        for (int k = begin; k > i; k--)
                        {
                            helpList.Add(num[k]);
                        }
                        var newList = helpList.OrderBy(f => f);
                        for (int k = 0; k <= i; k++)
                        {
                            text += num[k];
                        }
                        for (int k = 0; k < newList.Count(); k++)
                        {
                            text += newList.ElementAt(k);
                        }
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            newnumber = Convert.ToInt32(text);
            if (newnumber <= number)
            {
                newnumber = -1;
            }
            return newnumber;
        }
    }
}
