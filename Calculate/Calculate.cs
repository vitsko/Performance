namespace Calculate
{
    using System.Diagnostics;

    public abstract class Calculate
    {
        public const int CountOfObject = 2000000;
        private static Stopwatch watch;
        private static long overhead = -1;

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

        private static long Overhead
        {
            get
            {
                if (overhead == -1)
                {
                    watch.Reset();
                    watch.Start();

                    for (var i = 0; i < CalculateArrayList.CountOfObject; i++)
                    {
                    }

                    watch.Stop();

                    overhead = watch.ElapsedMilliseconds;
                }

                return overhead;
            }
        }

        public abstract long GetPerformanceToAdd();

        public abstract long GetPerformanceToSearch();

        public abstract long GetPerformanceToClear();

        protected static long GetResultWithoutOverhead()
        {
            return Watch.ElapsedMilliseconds - Calculate.Overhead;
        }
    }
}