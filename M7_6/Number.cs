using System;
using System.Linq;

namespace M7_6
{
    public class Number
    {
        public static string GetSumBigNumbers(string numberFirst, string numberSeconde)
        {
            string answer = null;
            string helperNumber = null;
            int lengthFirst = numberFirst.Length;
            int lengthSeconde = numberSeconde.Length;
            int differenceLength = 0;
            if (lengthFirst < lengthSeconde)
            {
                helperNumber = numberFirst;
                numberFirst = numberSeconde;
                numberSeconde = helperNumber;
                helperNumber = null;
                lengthFirst = numberFirst.Length;
                lengthSeconde = numberSeconde.Length;
            }
            differenceLength = lengthFirst - lengthSeconde;
            helperNumber = numberFirst;
            helperNumber = helperNumber.Remove(0, differenceLength);
            int num = 0;
            for (int i = lengthSeconde - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(numberSeconde.ElementAt(i).ToString()) + Convert.ToInt32(helperNumber.ElementAt(i).ToString()) + num < 10)
                {
                    answer += Convert.ToInt32(numberSeconde.ElementAt(i).ToString()) + Convert.ToInt32(helperNumber.ElementAt(i).ToString()) + num;
                    num = 0;
                }
                else
                {
                    answer += ((Convert.ToInt32(numberSeconde.ElementAt(i).ToString()) + Convert.ToInt32(helperNumber.ElementAt(i).ToString()) + num) % 10);
                    num = 1;
                }
            }
            for (int i = differenceLength - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(numberFirst.ElementAt(i).ToString()) + num < 10)
                {
                    answer += Convert.ToInt32(numberFirst.ElementAt(i).ToString()) + num;
                    num = 0;
                }
                else
                {
                    answer += (Convert.ToInt32(numberFirst.ElementAt(i).ToString()) + num) % 10;
                    num = 1;
                }
            }
            if (num==1)
            {
                answer += num;
            }
            return new string(answer.Reverse().ToArray());
        }
    }
}
