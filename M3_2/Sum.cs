﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace M3_2
{
    public class Sum
    {
        public static void Get(int[,] matrix)
        {
            List<AuxiliaryType> list = new List<AuxiliaryType>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                list.Add(new AuxiliaryType { Value = sum, Index = i });
            }
            Bubble.Get(list);
            Result.Show(list, matrix);
        }
    }
}