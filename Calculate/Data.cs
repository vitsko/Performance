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

        internal static Stack<object> GetDataForStack()
        {
            Stack<object> stack = new Stack<object>();

            for (var i = 0; i < Data.FirstPart; i++)
            {
                stack.Push(new object());
            }

            stack.Push(ForSearch);

            for (var i = 0; i < Data.SecondPart; i++)
            {
                stack.Push(new object());
            }

            return stack;
        }

        internal static Queue<object> GetDataForQueue()
        {
            Queue<object> queue = new Queue<object>();

            for (var i = 0; i < Data.FirstPart; i++)
            {
                queue.Enqueue(new object());
            }

            queue.Enqueue(ForSearch);

            for (var i = 0; i < Data.SecondPart; i++)
            {
                queue.Enqueue(new object());
            }

            return queue;
        }

        internal static Hashtable GetDataForHashtable()
        {
            Hashtable hashtable = new Hashtable();

            for (var i = 0; i < Data.FirstPart; i++)
            {
                hashtable.Add(i, new object());
            }

            hashtable.Add(Data.FirstPart, ForSearch);

            for (var i = 0; i < Data.SecondPart; i++)
            {
                hashtable.Add(i + 1 + Data.FirstPart, new object());
            }

            return hashtable;
        }

        internal static Dictionary<int, object> GetDataForDictionary()
        {
            Dictionary<int, object> dictionary = new Dictionary<int, object>();

            for (var i = 0; i < Data.FirstPart; i++)
            {
                dictionary.Add(i, new object());
            }

            dictionary.Add(Data.FirstPart, ForSearch);

            for (var i = 0; i < Data.SecondPart; i++)
            {
                dictionary.Add(i + 1 + Data.FirstPart, new object());
            }

            return dictionary;
        }
    }
}