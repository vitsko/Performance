namespace Calculate
{
    using System.Collections.Generic;
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

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            linkedList = Data.GetDataForLinkedList();

            Watch.Reset();
            Watch.Start();

            var node = linkedList.Find(Data.ForSearch);
            var result = node.Value;

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            if (linkedList.Count == 0)
            {
                linkedList = Data.GetDataForLinkedList();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                linkedList.RemoveLast();
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override string ToString()
        {
            return Text.LinkedList;
        }
    }
}