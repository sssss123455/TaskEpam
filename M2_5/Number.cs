using System;
using System.Collections.Generic;
using System.Linq;

namespace M2_5
{
    public class Number
    {
        public static int FindNextBiggerNumber(int number)
        {
            int nextBiggerNumber = -1;
            List<int> list = new List<int>();
            int index = -1;
            string numString = null;
            List<int> helperList = new List<int>();
            while (number > 0)
            {
                list.Add(number % 10);
                number = number / 10;
            }
            list.Reverse();
            for (int i = list.Count() - 1; i > 0; i--)
            {
                if (list[i] > list[i - 1])
                {
                    int num = list[i];
                    list[i] = list[i - 1];
                    list[i - 1] = num;
                    index = i;
                    break;
                }
            }
            if (index > -1)
            {
                for (int i = list.Count() - 1; i >= index; i--)
                {
                    helperList.Add(list[i]);
                }
                for (int i = 0; i < index; i++)
                {
                    numString += list[i];
                }
                foreach (var item in helperList.OrderBy(x => x))
                {
                    numString += item;
                }
                if (Convert.ToInt32(numString) > number)
                {
                    nextBiggerNumber = Convert.ToInt32(numString);
                }
            }
            return nextBiggerNumber;
        }
    }
}
