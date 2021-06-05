using M3_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace M9_2
{
    public class Result
    {
        delegate int[,] Method(int[,] matrix, string rule);
        public static List<int[,]> Get(int[,] matrix,string rule)
        {
            Method methodMax = Max.GetMatrix;
            Method methodMin = Min.GetMatrix;
            Method methodSum = Sum.GetMatrix;
            List<int[,]> list = new List<int[,]>();
            list.Add( methodMax( matrix,  rule));
            list.Add(methodMin(matrix, rule));
            list.Add(methodSum(matrix, rule));
            return list;
            

        }
    }
}
