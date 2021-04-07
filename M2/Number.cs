using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M2
{
    public  class Number
    {
        public int InsertNumber(int firstNumber,int secondNumber,int i,int j)
        {
            if (i <= j)
            {
                var firstNum = Translate(firstNumber);
                var secondNum = Translate(secondNumber);
                int count=j - i + 1;
                var numArray = secondNum.Take(count).ToArray();
                string number = null;
                for (int p = i; p <= j; p++)
                {
                    firstNum[p] = numArray[p - i];
                }
                foreach (var item in firstNum.Reverse().ToArray())
                {
                    number += item;
                }
                return Convert.ToInt32(number,2);
            }
            else throw new Exception("Error i<j");
            
        }
        private static char[] Translate(int number)
        {
            string num = Convert.ToString(number, 2);
            char[] answer = new char[32];
            int size = 32 - num.Count();
            for (int i = 0; i < size; i++)
            {
                num = "0" + num;
            }
            answer = num.ToArray().Reverse().ToArray();
            return answer;
        }
    }
}
