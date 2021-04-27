using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace M4_1
{
    public static class DoubleExtension
    {
        public static  unsafe string GetIEEE754(this double num)
        {
            var n = *(long*)&num;

            var sign64 = n >> 63 & 0x01;
            var exponent64 = n >> 52 & 0x7FF;
            var mantissa64 = n & 0x1FFFFFFFFFFFFF;
            return (GetForm(sign64,1)+ GetForm(exponent64, 11)+ GetForm(mantissa64, 52));
        }
        private static string GetForm(double num,int count)
        {
            string number = null;
            List<ulong> list = new List<ulong>();
            double n;
            do
            {
                n = Math.Truncate(num / 2);
                list.Add((ulong)Math.Truncate(num % 2));
                num = n;
            } while (n != 0&&list.Count()< count);
            list.Reverse();
            foreach (var item in list)
            {
                number += item;
            }
           
            return number.PadLeft(count, '0');
        }
        public static char[]  GetIEEE754Two(this double num)
        {
            var unit_d = DoubleToInt64Bits(num);
            char[] str = new char[64];
            for (var i = 0; i < 64; i++)
            {
                if (((unit_d >> i) & 0b01) == 1)
                {
                    str[64 - i - 1] = '1';
                }
                else
                {
                    str[64 - i - 1] = '0';
                }
            }
            return str;
        }
        public unsafe static long DoubleToInt64Bits(double value)
        {
            return *(long*)(&value);
        }
    }
} 

