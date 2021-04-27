using System;
using System.Collections.Generic;
using System.Text;

namespace M4_3
{
    public static  class ObjectExtension
    {
        public static bool IsNull(this object value)
        {
            if (value == null)
                return true;
            else
                return false;
        }
    }
}
