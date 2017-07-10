namespace Calculate
{
    using System.Collections.Generic;
    using System.Linq;
    using Text;

    public class CalculateDictionary : Calculate
    {
        private static Dictionary<int, object> dictionary = new Dictionary<int, object>();

        public override long GetPerformanceToAdd()
        {
            if (dictionary.Count != 0)
            {
                dictionary.Clear();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                dictionary.Add(i, new object());
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            dictionary = Data.GetDataForDictionary();

            Watch.Reset();
            Watch.Start();

            var result = dictionary.Where(item => item.Value.Equals(Data.ForSearch))
                                   .First(item => item.Value.Equals(Data.ForSearch))
                                   .Value;

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            if (dictionary.Count == 0)
            {
                dictionary = Data.GetDataForDictionary();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                dictionary.Remove(i);
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override string ToString()
        {
            return Text.Dictionary;
        }
    }
}