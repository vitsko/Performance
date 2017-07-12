namespace Calculate
{
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

            return Calculate.GetResultWithoutOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            stack = (Stack<object>)Data.ListObject.Find(item => item is Stack<object>);

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
                stack = (Stack<object>)Data.ListObject.Find(item => item is Stack<object>);
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                stack.Pop();
            }

            Watch.Stop();

            return Calculate.GetResultWithoutOverhead();
        }

        public override string ToString()
        {
            return Text.Stack;
        }
    }
}