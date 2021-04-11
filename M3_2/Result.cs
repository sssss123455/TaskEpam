using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3_2
{
    public class Result
    {
        public static void Show(List<AuxiliaryType> list,int[,] matrix)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[list[i].Index, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
