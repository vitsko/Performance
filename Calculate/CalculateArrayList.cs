namespace Calculate
{
    using System.Collections;
    using System.Linq;
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

            return Calculate.GetResultWithoutOverhead();
        }

        public override long GetPerformanceToSearch()
        {
            arrayList = (ArrayList)Data.ListObject.Find(item => item is ArrayList);

            Watch.Reset();
            Watch.Start();

            var result = arrayList.OfType<string>()
                                  .Where(item => item.Equals(Data.ForSearch));

            Watch.Stop();

            return Watch.ElapsedMilliseconds;
        }

        public override long GetPerformanceToClear()
        {
            if (arrayList.Count == 0)
            {
                arrayList = (ArrayList)Data.ListObject.Find(item => item is ArrayList);
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