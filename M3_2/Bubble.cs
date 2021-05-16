using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M3_2
{
    public class Bubble
    {
        public static void Get(List<AuxiliaryType> list)
        {
            int k;
            int n = list.Count();
            AuxiliaryType num;
            while (n > 1)
            {
                k = 0;
                for (int i = 1; i < n; i++)
                {
                    if (list[i].Value < list[i - 1].Value)
                    {
                        num = list[i];
                        list[i] = list[i - 1];
                        list[i - 1] = num;
                        k = i;
                    }
                }
                n = k;
            }
        }
        public static void Get(List<AuxiliaryType> list,string st)
        {
            int k;
            int n = list.Count();
            AuxiliaryType num;
            while (n > 1)
            {
                k = 0;
                for (int i = 1; i < n; i++)
                {
                    if (st=="up")
                    {
                        if (list[i].Value < list[i - 1].Value)
                        {
                            num = list[i];
                            list[i] = list[i - 1];
                            list[i - 1] = num;
                            k = i;
                        }
                    }
                    else
                    {
                        if (st=="down")
                        {
                            if (list[i].Value > list[i - 1].Value)
                            {
                                num = list[i];
                                list[i] = list[i - 1];
                                list[i - 1] = num;
                                k = i;
                            }
                        }
                        else
                        {
                            throw new Exception("up при сортировке по возрастанию, down при сортировке по убыванию");
                        }
                    }
                }
                n = k;
            }
        }
    }
}
