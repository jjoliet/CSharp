using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CSharpAlgorithmsAndDataStructures
{
    class Timer
    {
        TimeSpan startTime;
        TimeSpan duration;

        public Timer()
        {
            startTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public void StopTime()
        {
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);
        }

        public void Result()
        {
            Console.WriteLine("It took: {0} Seconds", duration);
        }
    }
}
