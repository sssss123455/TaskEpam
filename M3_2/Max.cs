using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3_2
{
    public class Max
    {
        public static void Get(int[,] matrix)
        {
            List<AuxiliaryType> list = new List<AuxiliaryType>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
                list.Add(new AuxiliaryType { Value = max, Index = i });
            }
            Bubble.Get(list);
            Result.Show(list, matrix);
        }
        public static void Get(int[,] matrix,string st)
        {
            List<AuxiliaryType> list = new List<AuxiliaryType>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
                list.Add(new AuxiliaryType { Value = max, Index = i });
            }
            Bubble.Get(list,st);
            Result.Show(list, matrix);
        }
        public static int[,] GetMatrix(int[,] matrix, string st)
        {
            List<AuxiliaryType> list = new List<AuxiliaryType>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int max = int.MinValue;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i, j])
                    {
                        max = matrix[i, j];
                    }
                }
                list.Add(new AuxiliaryType { Value = max, Index = i });
            }
            Bubble.Get(list, st);
            return Matrix.Get(list, matrix);
        }
    }
}
