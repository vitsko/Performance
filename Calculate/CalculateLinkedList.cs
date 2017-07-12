namespace Calculate
{
    using System.Collections.Generic;
    using System.Linq;
    using Text;

    public class CalculateLinkedList : Calculate
    {
        private static LinkedList<object> linkedList = new LinkedList<object>();

        public override long GetPerformanceToAdd()
        {
            if (linkedList.Count != 0)
            {
                linkedList.Clear();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                linkedList.AddLast(new object());
            }

            Watch.Stop();

            return Calculate.GetResultWithoutOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            linkedList = (LinkedList<object>)Data.ListObject.Find(item => item is LinkedList<object>);

            Watch.Reset();
            Watch.Start();

            var result = linkedList.Where(item => item.Equals(Data.ForSearch));

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            if (linkedList.Count == 0)
            {
                linkedList = (LinkedList<object>)Data.ListObject.Find(item => item is LinkedList<object>);
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                linkedList.RemoveLast();
            }

            Watch.Stop();

            return Calculate.GetResultWithoutOverhead();
        }

        public override string ToString()
        {
            return Text.LinkedList;
        }
    }
}