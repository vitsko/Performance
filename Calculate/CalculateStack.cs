namespace Calculate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Text;

    public class CalculateStack : Calculate
    {
        private static Stack<object> stack = new Stack<object>();

        public override long GetPerformanceToAdd()
        {
            if (stack.Count != 0)
            {
                stack.Clear();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                stack.Push(new object());
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            stack = Data.GetDataForStack();

            Watch.Reset();
            Watch.Start();

            var result = stack.Where(item => item.Equals(Data.ForSearch));

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            if (stack.Count == 0)
            {
                stack = Data.GetDataForStack();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                stack.Pop();
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override string ToString()
        {
            return Text.Stack;
        }
    }
}
