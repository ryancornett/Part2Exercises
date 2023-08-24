namespace ClassExercises
{
    internal static class StopwatchLogic
    {
        public static TimeSpan GetTotalTime(TimeSpan thisSpan)
        {
            return Stopwatch.totalTime += thisSpan;
        }

        public static string FormatElapsedTime(TimeSpan elapsed)
        {
            string[] elapsedArray = elapsed.ToString().Split('.');
            return $"{elapsedArray[0]}.{elapsedArray[1].Remove(2)}";
        }
    }
}
