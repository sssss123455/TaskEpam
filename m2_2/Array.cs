using System;
using System.Collections.Generic;
using System.Text;

namespace m2_2
{
    public class Array
    {
        public  int GetMaxNumber(int[] array)
        {
            int maxNumber = array[0];
            foreach (var item in array)
            {
                if (item>maxNumber)
                {
                    maxNumber = item;
                }
            }
            return maxNumber;
        }
    }
}
