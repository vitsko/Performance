using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class CalculateArrayList : Calculate
    {
        private static ArrayList arrayList = new ArrayList();

        public override long Add()
        {
            watch.Reset();
            watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                arrayList.Add(new object());
            }

            watch.Stop();

            return watch.ElapsedMilliseconds - Calculate.GetOverhead();
        }

        public override long Search()
        {
            var listToSearch = Data.GetDataForArrayList();

            watch.Reset();
            watch.Start();

            var indexResult = listToSearch.IndexOf(Data.ForSearch);
            var result = listToSearch[indexResult];

            watch.Stop();

            return watch.ElapsedMilliseconds;
        }

        public override long Clear()
        {
            watch.Reset();
            watch.Start();

            arrayList.RemoveRange(0, CalculateArrayList.CountOfObject);

            watch.Stop();

            return watch.ElapsedMilliseconds;
        }
    }
}