using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace M9_3
{
    public class Countdown
    {
        private bool Flag;
        public event EventHandler<CheckPoint> CheckPoints;
        public event EventHandler StartRun;
        public void Run()
        {
            Start();
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Point(new CheckPoint {Num=i,Flag=false });
                }

                if (Flag)
                {
                    break;
                }
            }
        }
        protected virtual void Start()
        {
            StartRun?.Invoke(this, null);
        }
        protected virtual void Point(CheckPoint point)
        {
            if (point==null)
            {
                throw new ArgumentNullException();
            }
            CheckPoints?.Invoke(this, point);
            Flag = point.Flag;

        }

    }
    public class CheckPoint:EventArgs
    {
        public int Num { get; set;  } 
        public bool Flag { get; set; }
    }
}
