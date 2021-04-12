using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M2_6
{
    public class Array
    {
        public static List<int> FilterDigit(int[] array,int number)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                //List<int> helperList = GetListOfNumber(array[i]);
                char[] n = array[i].ToString().ToArray();
                foreach (var item in n)
                {
                    if (Convert.ToInt32(item.ToString())==number)
                    {
                        list.Add(array[i]);
                    }
                }
            }
            return list;
        }
        //private static List<int> GetListOfNumber(int num)
        //{
        //    List<int> list = new List<int>();
        //    while (num > 0)
        //    {
        //        list.Add(num % 10);
        //        num = num / 10;
        //    }
        //    return list;
        //}
    }
}
