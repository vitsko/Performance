﻿namespace Calculate
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Text;

    public class CalculateHashTable : Calculate
    {
        private static Hashtable hashtable = new Hashtable();

        public override long GetPerformanceToAdd()
        {
            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                hashtable.Add(i, new object());
            }

            Watch.Stop();

            hashtable.Clear();

            return Calculate.GetResultWithoutOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            hashtable = (Hashtable)Data.ListObject.Find(item => item is Hashtable);

            Watch.Reset();
            Watch.Start();

            var result = hashtable.Values
                        .OfType<string>()
                        .ToList()
                        .Where(item => item.Equals(Data.ForSearch));

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            hashtable = (Hashtable)Data.GetValue().Find(item => item is Hashtable);

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                hashtable.Remove(i);
            }

            Watch.Stop();

            return Calculate.GetResultWithoutOverhead();
        }

        public override string ToString()
        {
            return Text.HashTable;
        }
    }
}