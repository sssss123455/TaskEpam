using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace M9_3
{
    public class CountDown
    {
        public delegate void Method();
        public event Method onCount;
        public void Count()
        {
            Thread.Sleep(9000);
            onCount();  
        }
    }
}
