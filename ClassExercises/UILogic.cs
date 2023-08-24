using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public static class UILogic
    {
        public static void RunStopwatch()
        {
            var stopwatch = new Stopwatch();
            bool runApp = true;

            while (runApp)
            {
                Console.WriteLine("Press enter to start the stopwatch.");
                Console.ReadLine();
                var startTime = stopwatch.Start();
                Console.WriteLine("Press enter to stop the stopwatch.");
                Console.ReadLine();
                Console.WriteLine($"{stopwatch.FormatElapsedTime(stopwatch.Stop(startTime))} seconds");
                Console.ReadLine();
            }
        }
    }
}
