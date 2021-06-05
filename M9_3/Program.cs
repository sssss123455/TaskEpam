using System;

namespace M9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown countDown = new CountDown();
            MessageFirst messageFirst = new MessageFirst();
            MessageSecond messageSecond = new MessageSecond();
            countDown.onCount += messageFirst.Message;
            countDown.onCount += messageSecond.Message;
            countDown.Count();
        }
    }
}
