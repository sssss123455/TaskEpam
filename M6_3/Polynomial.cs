using System;
using System.Collections.Generic;
using System.Text;

namespace M6_3
{
    public class Polynomial
    {
        public int[] Coefficient { get; set; }
        public Polynomial(int[] coefficient)
        {
            this.Coefficient = coefficient;
        }
        public override string ToString()
        {
            string polynomial = $"({Coefficient[0]})";
            for (int i = 1; i < Coefficient.Length; i++)
            {
                polynomial += $"+({Coefficient[i]})*x^{i}";
            }
            return polynomial;
        }
        public override int GetHashCode()
        {
            return Coefficient.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            bool answer = false;
            int count = 0;
            if (obj.GetType() != this.GetType()) return false;
            Polynomial polynomial = (Polynomial)obj;
            if (this.Coefficient.Length != polynomial.Coefficient.Length) return false;
            for (int i = 0; i < polynomial.Coefficient.Length; i++)
            {
                if (this.Coefficient[i] != polynomial.Coefficient[i]) break;
                count++;
            }
            if (count == polynomial.Coefficient.Length) answer = true;
            return answer;
        }
        public static Polynomial operator +(Polynomial polynomialFirst, Polynomial polynomialSecond)
        {
            if (polynomialFirst.Coefficient.Length == polynomialSecond.Coefficient.Length)
            {
                for (int i = 0; i < polynomialFirst.Coefficient.Length; i++)
                {
                    polynomialFirst.Coefficient[i] += polynomialSecond.Coefficient[i];
                }
                return polynomialFirst;
            }
            else
            {
                if (polynomialFirst.Coefficient.Length > polynomialSecond.Coefficient.Length)
                {
                    for (int i = 0; i < polynomialSecond.Coefficient.Length; i++)
                    {
                        polynomialFirst.Coefficient[i] += polynomialSecond.Coefficient[i];
                    }
                    return polynomialFirst;
                }
                else
                {
                    if (polynomialFirst.Coefficient.Length < polynomialSecond.Coefficient.Length)
                    {
                        for (int i = 0; i < polynomialFirst.Coefficient.Length; i++)
                        {
                            polynomialSecond.Coefficient[i] += polynomialFirst.Coefficient[i];
                        }
                        return polynomialSecond;
                    }
                }
            }
            throw new Exception("Error");
        }
        public static Polynomial operator -(Polynomial polynomialFirst, Polynomial polynomialSecond)
        {
            if (polynomialFirst.Coefficient.Length == polynomialSecond.Coefficient.Length)
            {
                for (int i = 0; i < polynomialFirst.Coefficient.Length; i++)
                {
                    polynomialFirst.Coefficient[i] -= polynomialSecond.Coefficient[i];
                }
                return polynomialFirst;
            }
            else
            {
                if (polynomialFirst.Coefficient.Length > polynomialSecond.Coefficient.Length)
                {
                    for (int i = 0; i < polynomialSecond.Coefficient.Length; i++)
                    {
                        polynomialFirst.Coefficient[i] -= polynomialSecond.Coefficient[i];
                    }
                    return polynomialFirst;
                }
                else
                {
                    if (polynomialFirst.Coefficient.Length < polynomialSecond.Coefficient.Length)
                    {
                        for (int i = 0; i < polynomialFirst.Coefficient.Length; i++)
                        {
                            polynomialSecond.Coefficient[i] -= polynomialFirst.Coefficient[i];
                        }
                        return polynomialSecond;
                    }
                }
            }
            throw new Exception("Error");
        }
        public static Polynomial operator *(Polynomial polynomial,int num)
        {
            for (int i = 0; i < polynomial.Coefficient.Length; i++)
            {
                polynomial.Coefficient[i] = polynomial.Coefficient[i] * num;
            }
            return polynomial;
        }
        public static Polynomial operator /(Polynomial polynomial, int num)
        {
            if (num != 0)
            {
                for (int i = 0; i < polynomial.Coefficient.Length; i++)
                {
                    polynomial.Coefficient[i] = polynomial.Coefficient[i] / num;
                }
                return polynomial;
            }
            throw new Exception("num не должен быть равен 0");
        }

    }
}
