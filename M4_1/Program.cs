using System;
using System.Collections;
using System.Collections.Generic;

namespace M4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(double.Epsilon.GetIEEE754());
            var d=double.Epsilon.GetIEEE754Two();
            Console.WriteLine(d);
        }
    }
}
