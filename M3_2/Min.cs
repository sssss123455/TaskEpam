using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3_2
{
    public class Min
    {
        public static void Get(int[,] matrix)
        {
            List<AuxiliaryType> list = new List<AuxiliaryType>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (min > matrix[i, j])
                    {
                        min = matrix[i, j];
                    }
                }
                list.Add(new AuxiliaryType { Value = min, Index = i });
            }
            Bubble.Get(list);
            Result.Show(list, matrix);
        }
    }
}
