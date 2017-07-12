namespace Calculate
{
    using System.Diagnostics;

    public abstract class Calculate
    {
        public const int CountOfObject = 2000000;
        private static Stopwatch watch;

        protected static Stopwatch Watch
        {
            get
            {
                if (watch == null)
                {
                    watch = new Stopwatch();
                }

                return watch;
            }
        }

        public abstract long GetPerformanceToAdd();

        public abstract long GetPerformanceToSearch();

        public abstract long GetPerformanceToClear();

        protected static long GetOverhead()
        {
            watch.Reset();
            watch.Start();

            for (var i = 0; i < CalculateArrayList.CountOfObject; i++)
            {
            }

            watch.Stop();

            return watch.ElapsedMilliseconds;
        }

        protected static long GetResultWithoutOverhead()
        {
            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }
    }
}