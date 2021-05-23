using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
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
            list=list.Distinct().ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
