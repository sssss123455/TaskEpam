using System;

namespace M9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown countdown = new Countdown();
            countdown.CheckPoints += RunHandler;
            countdown.StartRun += StartHandler;
            countdown.Run();
            Console.WriteLine("end");

        }
        private static void StartHandler(object sender, EventArgs point)
        {
            Console.WriteLine("start");
        }
        private static void RunHandler(object sender, CheckPoint point)
        {
            Console.WriteLine($"{point.Num}");
            if (point.Num>=70)
            {
                point.Flag=true;
            }
        }
    }
}
