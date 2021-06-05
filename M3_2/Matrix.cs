using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3_2
{
    public class Matrix
    {
        public static int[,] Get(List<AuxiliaryType> list, int[,] matrix)
        {
            int[,] newMatrix = matrix;
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[list[i].Index, j];
                }
            }
            return newMatrix; 
        }
    }
}
