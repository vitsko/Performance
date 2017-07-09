using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public abstract class Calculate
    {
        internal const int CountOfObject = 20000;
        protected static Stopwatch watch = new Stopwatch();

        public abstract long Add();
        public abstract long Search();
        public abstract long Clear();

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
    }
}