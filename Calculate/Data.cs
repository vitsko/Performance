namespace Calculate
{
    using System.Collections;
    using System.Collections.Generic;

    internal static class Data
    {
        internal const string ForSearch = "search";
        private const int FirstPart = 1000000,
                          SecondPart = 999999,
                          Capacity = 2000000;

        private static ArrayList array;
        private static LinkedList<object> linkedList;

        private static Stack<object> stack;
        private static Queue<object> queue;

        private static Hashtable hashtable;
        private static Dictionary<int, object> dictionary;

        private static List<object> listObject;

        internal static List<object> ListObject
        {
            get
            {
                if (listObject == null)
                {
                    Data.SetValurByCount(Data.FirstPart);
                    Data.SetValueForSearch();

                    for (var i = 0; i < Data.SecondPart; i++)
                    {
                        array.Add(new object());
                        linkedList.AddLast(new object());

                        stack.Push(new object());
                        queue.Enqueue(new object());

                        hashtable.Add(i + 1 + Data.FirstPart, new object());
                        dictionary.Add(i + 1 + Data.FirstPart, new object());
                    }

                    listObject = new List<object>()
                    {
                        array,
                        linkedList,
                        stack,
                        queue,
                        hashtable,
                        dictionary
                    };
                }

                return listObject;
            }
        }

        internal static List<object> GetValue()
        {
            Data.SetValurByCount(Data.Capacity);

            return new List<object>
                       {
                        array,
                        linkedList,
                        stack,
                        queue,
                        hashtable,
                        dictionary
                       };
        }

        private static void SetValurByCount(int count)
        {
            array = new ArrayList();
            linkedList = new LinkedList<object>();

            stack = new Stack<object>();
            queue = new Queue<object>();

            hashtable = new Hashtable();
            dictionary = new Dictionary<int, object>();

            for (var i = 0; i < count; i++)
            {
                array.Add(new object());
                linkedList.AddLast(new object());

                stack.Push(new object());
                queue.Enqueue(new object());

                dictionary.Add(i, new object());
                hashtable.Add(i, new object());
            }
        }

        private static void SetValueForSearch()
        {
            array.Add(ForSearch);
            linkedList.AddLast(ForSearch);

            stack.Push(ForSearch);
            queue.Enqueue(ForSearch);

            hashtable.Add(Data.FirstPart, ForSearch);
            dictionary.Add(Data.FirstPart, ForSearch);
        }
    }
}