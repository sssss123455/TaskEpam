using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace M7_4
{
    public class Element
    {
        public static void UniqueInOrder(IEnumerable values)
        {
            List<object> list = new List<object>();
            var value = values.GetEnumerator();
            while (value.MoveNext())
            {
                list.Add((object)value.Current);
            }
            for (int i = 1; i < list.Count(); i++)
            {
                while (list[i].ToString() == list[i - 1].ToString() && i!=list.Count()-1)
                {
                    list.RemoveAt(i);
                }
                if (list[i].ToString() == list[i - 1].ToString()&& i == list.Count() - 1)
                {
                    list.RemoveAt(i);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
