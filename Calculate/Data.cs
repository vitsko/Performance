namespace Calculate
{
    using System.Collections;
    using System.Collections.Generic;

    internal static class Data
    {
        internal const string ForSearch = "search";
        private const int FirstPart = 1000000,
                          SecondPart = 999999;

        internal static ArrayList GetDataForArrayList()
        {
            ArrayList array = new ArrayList();

            for (var i = 0; i < Data.FirstPart; i++)
            {
                array.Add(new object());
            }

            array.Add(ForSearch);

            for (var i = 0; i < Data.SecondPart; i++)
            {
                array.Add(new object());
            }

            return array;
        }

        internal static LinkedList<object> GetDataForLinkedList()
        {
            LinkedList<object> linkedList = new LinkedList<object>();

            for (var i = 0; i < Data.FirstPart; i++)
            {
                linkedList.AddLast(new object());
            }

            linkedList.AddLast(ForSearch);

            for (var i = 0; i < Data.SecondPart; i++)
            {
                linkedList.AddLast(new object());
            }

            return linkedList;
        }
    }
}