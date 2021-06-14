using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace M10_1
{
    public class Binary
    {
        public static int Show<T> ( List<T> list,T value) 
        {
            return list.BinarySearch(value);
        }
    }
}
