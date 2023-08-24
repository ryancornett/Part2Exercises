namespace ClassExercises
{
    public class Stopwatch
    {
        public bool running { get; set; }
        public static TimeSpan totalTime { get; set; }

        public DateTime Start()
        {
            running = true;
            return DateTime.Now;
        }
        
        public TimeSpan Stop(DateTime dateTime)
        {
            running = false;
            TimeSpan thisSpan = DateTime.Now - dateTime;
            return StopwatchLogic.GetTotalTime(thisSpan);
        }
    }
}
