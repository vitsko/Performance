namespace Calculate
{
    using System.Collections;
    using Text;

    public class CalculateHashTable : Calculate
    {
        private const int KeyForSearch = 1000000;
        private static Hashtable hashtable = new Hashtable();

        public override long GetPerformanceToAdd()
        {
            if (hashtable.Count != 0)
            {
                hashtable.Clear();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                hashtable.Add(i, new object());
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            hashtable = Data.GetDataForHashtable();

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                if (hashtable[i].Equals(Data.ForSearch))
                {
                    var result = hashtable[i];
                    break;
                }
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override long GetPerformanceToClear()
        {
            if (hashtable.Count == 0)
            {
                hashtable = Data.GetDataForHashtable();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                hashtable.Remove(i);
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override string ToString()
        {
            return Text.HashTable;
        }
    }
}