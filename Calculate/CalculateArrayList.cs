namespace Calculate
{
    using System.Collections;
    using Text;

    public class CalculateArrayList : Calculate
    {
        private static ArrayList arrayList = new ArrayList();

        public override long GetPerformanceToAdd()
        {
            Watch.Reset();
            Watch.Start();

            for (var i = 0; i < Calculate.CountOfObject; i++)
            {
                arrayList.Add(new object());
            }

            Watch.Stop();

            arrayList.Clear();

            return Calculate.GetResultWithoutOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            arrayList = (ArrayList)Data.ListObject.Find(item => item is ArrayList);

            Watch.Reset();
            Watch.Start();

            var index = arrayList.IndexOf(Data.ForSearch);
            var result = arrayList[index];

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            arrayList = (ArrayList)Data.GetValue().Find(item => item is ArrayList);

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