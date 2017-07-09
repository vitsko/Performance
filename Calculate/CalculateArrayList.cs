﻿namespace Calculate
{
    using System.Collections;
    using Text;

    public class CalculateArrayList : Calculate
    {
        private static ArrayList arrayList = new ArrayList();

        public override long GetPerformanceToAdd()
        {
            if (arrayList.Count != 0)
            {
                arrayList.Clear();
            }

            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                arrayList.Add(new object());
            }

            Watch.Stop();

            return Watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            arrayList = Data.GetDataForArrayList();

            Watch.Reset();
            Watch.Start();

            var indexResult = arrayList.IndexOf(Data.ForSearch);
            var result = arrayList[indexResult];

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            if (arrayList.Count == 0)
            {
                arrayList = Data.GetDataForArrayList();
            }

            Watch.Reset();
            Watch.Start();

            arrayList.RemoveRange(0, CalculateArrayList.CountOfObject);

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override string ToString()
        {
            return Text.ArrayList;
        }
    }
}