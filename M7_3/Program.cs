using System;

namespace M7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Url.AddOrChangeUrlParameter("www.example.com", "key=value"));
            Console.WriteLine(Url.AddOrChangeUrlParameter("www.example.com?key=value", "key2=value2"));
            Console.WriteLine(Url.AddOrChangeUrlParameter("www.example.com?key=oldValue", "key=newValue"));
        }
    }
}
