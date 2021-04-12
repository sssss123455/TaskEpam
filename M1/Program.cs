using System;
using MyLibrary;

namespace M1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Hi");
            person.GetMessage();
            MyLibraary.ShowMessage();
        }
    }
}
