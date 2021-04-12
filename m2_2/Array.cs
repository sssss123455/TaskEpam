using System;
using System.Collections.Generic;
using System.Text;

namespace m2_2
{
    public class Array
    {
        public static  int GetMaxNumber(int[] array,int i,int maxNumber)
        {

            if (i == array.Length)
            {
                return maxNumber;
            }
            else
            {
                if (maxNumber<array[i])
                {
                    return GetMaxNumber(array, i + 1, array[i]);
                }
                else
                {
                    return GetMaxNumber(array, i + 1, maxNumber);
                }
            }
        }
       
    }
}
