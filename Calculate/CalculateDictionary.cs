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

            return Calculate.GetResultWithoutOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            dictionary = (Dictionary<int, object>)Data.ListObject.Find(item => item is Dictionary<int, object>);

            Watch.Reset();
            Watch.Start();

            var result = dictionary.Values
                                   .OfType<string>()
                                   .Where(item => item.Equals(Data.ForSearch));

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            if (dictionary.Count == 0)
            {
                dictionary = (Dictionary<int, object>)Data.ListObject.Find(item => item is Dictionary<int, object>);
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                dictionary.Remove(i);
            }

            Watch.Stop();

            return Calculate.GetResultWithoutOverhead();
        }

        public override string ToString()
        {
            return Text.Dictionary;
        }
    }
}