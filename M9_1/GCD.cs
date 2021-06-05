using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace M9_1
{
    public class GCD
    {
        delegate int UseMethod(int firstNum, int secondNum);
        private static int UseEuclid(int firstNum, int secondNum)
        {
            firstNum = Math.Abs(firstNum);
            secondNum = Math.Abs(secondNum);
            while (firstNum != secondNum)
            {
                if (firstNum > secondNum)
                {
                    firstNum = firstNum - secondNum;
                }
                else
                {
                    secondNum = secondNum - firstNum;
                }
            }
            return firstNum;
        }
        private static int UseBinary(int firstNum, int secondNum)
        {
            if (firstNum == secondNum)
                return firstNum;
            if (firstNum == 0)
                return secondNum;
            if (secondNum == 0)
                return firstNum;
            if ((~firstNum & 1) != 0)
            {
                if (secondNum % 2 != 0)
                    return UseBinary(firstNum, secondNum / 2);
                if (firstNum > secondNum)
                    return UseBinary((firstNum - secondNum) / 2, secondNum);
                else
                    return UseBinary((secondNum - firstNum) / 2, firstNum);
            }
            else
            {
                if ((~secondNum & 1) != 0)
                    return UseBinary(firstNum / 2, secondNum);
                else
                    return 2 * UseBinary(firstNum / 2, secondNum / 2);
            }
        }
        public static void ShowGCD(int[] arrayNum)
        {
            UseMethod methodE = UseEuclid;
            UseMethod methodB = UseBinary;
            int firstNumForEuclid = arrayNum[0];
            int secondNumForEuclid;
            int firstNumForBinary = arrayNum[0];
            int secondNumForBinary;
            Stopwatch swatch = new Stopwatch();
            swatch.Start();
            for (int i = 1; i < arrayNum.Length; i++)
            {
                secondNumForEuclid = arrayNum[i];
                firstNumForEuclid = methodE(firstNumForEuclid, secondNumForEuclid);
            }
            swatch.Stop();
            Console.WriteLine($"НОД Евклидом: {firstNumForEuclid}. Время на выполнения:{swatch.Elapsed}");
            Stopwatch swatchTwo = new Stopwatch();
            swatchTwo.Start();
            for (int i = 1; i < arrayNum.Length; i++)
            {
                secondNumForBinary = arrayNum[i];
                firstNumForBinary = methodB(firstNumForBinary, secondNumForBinary);
            }
            swatchTwo.Stop();
            Console.WriteLine($"НОД Бинарный: {firstNumForEuclid}. Время на выполнения:{swatchTwo.Elapsed}");
        }
        
    }
}
