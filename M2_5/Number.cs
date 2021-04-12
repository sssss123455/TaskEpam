using System;
using System.Collections.Generic;
using System.Linq;

namespace M2_5
{
    public class Number
    {
        public static long FindNextBiggerNumber(int number)
        {
            long nextBiggerNumber = -1;
           // List<int> list = new List<int>();
            int index = -1;
            string numString = null;
            char[] n = number.ToString().ToArray();
            List<int> helperList = new List<int>();
            //while (number > 0)
            //{
            //    list.Add(number % 10);
            //    number = number / 10;
            //}
            //list.Reverse();
            for (int i = n.Count() - 1; i > 0; i--)
            {
                if (n[i] > n[i - 1])
                {
                    char num = n[i];
                    n[i] = n[i - 1];
                    n[i - 1] = num;
                    index = i;
                    break;
                }
            }
            if (index > -1)
            {
                for (int i = n.Count() - 1; i >= index; i--)
                {
                    helperList.Add(n[i]);
                }
                for (int i = 0; i < index; i++)
                {
                    numString += n[i];
                }
                foreach (var item in helperList.OrderBy(x => x))
                {
                    numString += item;
                }
                Console.WriteLine(numString);
                if (Convert.ToInt64(numString.ToString()) > number)
                {
                    nextBiggerNumber = Convert.ToInt64(numString.ToString());
                }
            }
            return nextBiggerNumber;
        }
    }
}
