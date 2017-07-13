namespace Calculate
{
    using System.Collections.Generic;
    using Text;

    public class CalculateLinkedList : Calculate
    {
        private static LinkedList<object> linkedList = new LinkedList<object>();

        public override long GetPerformanceToAdd()
        {
            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                linkedList.AddLast(new object());
            }

            Watch.Stop();

            linkedList.Clear();

            return Calculate.GetResultWithoutOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            linkedList = (LinkedList<object>)Data.ListObject.Find(item => item is LinkedList<object>);

            Watch.Reset();
            Watch.Start();

            var node = linkedList.Find(Data.ForSearch);
            var result = node.Value;

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            linkedList = (LinkedList<object>)Data.GetValue().Find(item => item is LinkedList<object>);

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