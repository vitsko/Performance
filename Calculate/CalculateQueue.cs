namespace Calculate
{
    using System.Collections.Generic;
    using System.Linq;
    using Text;

    public class CalculateQueue : Calculate
    {
        private static Queue<object> queue = new Queue<object>();

        public override long GetPerformanceToAdd()
        {
            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                queue.Enqueue(new object());
            }

            Watch.Stop();

            queue.Clear();

            return Calculate.GetResultWithoutOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            queue = (Queue<object>)Data.ListObject.Find(item => item is Queue<object>);

            Watch.Reset();
            Watch.Start();

            var result = queue.ToArray().Where(item => item.Equals(Data.ForSearch));

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            queue = (Queue<object>)Data.GetValue().Find(item => item is Queue<object>);

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                queue.Dequeue();
            }

            Watch.Stop();

            return Calculate.GetResultWithoutOverhead();
        }

        public override string ToString()
        {
            return Text.Queue;
        }
    }
}
