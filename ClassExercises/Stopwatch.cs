using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    public class Stopwatch
    {
        public bool running { get; set; }
        public TimeSpan totalTime { get; set; }

        public DateTime Start()
        {
            running = true;
            return DateTime.Now;
        }
        
        public TimeSpan Stop(DateTime dateTime)
        {
            running = false;
            TimeSpan thisSpan = DateTime.Now - dateTime;
            return GetTotalTime(thisSpan);
        }

        public TimeSpan GetTotalTime(TimeSpan thisSpan)
        {
            return totalTime += thisSpan;
        }

        public string FormatElapsedTime(TimeSpan elapsed)
        {
            string[] elapsedArray = elapsed.ToString().Split('.');
            return $"{elapsedArray[0]}.{elapsedArray[1].Remove(2)}";
        }

    }
}
