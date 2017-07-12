namespace Calculate
{
    using System.Collections;
    using System.Collections.Generic;

    internal static class Data
    {
        internal const string ForSearch = "search";
        private const int FirstPart = 1000000,
                          SecondPart = 999999;

        private static List<object> listObject;

        internal static List<object> ListObject
        {
            get
            {
                if (listObject == null)
                {
                    ArrayList array = new ArrayList();
                    LinkedList<object> linkedList = new LinkedList<object>();

                    Stack<object> stack = new Stack<object>();
                    Queue<object> queue = new Queue<object>();

                    Hashtable hashtable = new Hashtable();
                    Dictionary<int, object> dictionary = new Dictionary<int, object>();

                    for (var i = 0; i < Data.FirstPart; i++)
                    {
                        array.Add(new object());
                        linkedList.AddLast(new object());

                        stack.Push(new object());
                        queue.Enqueue(new object());

                        dictionary.Add(i, new object());
                        hashtable.Add(i, new object());
                    }

                    array.Add(ForSearch);
                    linkedList.AddLast(ForSearch);

                    stack.Push(ForSearch);
                    queue.Enqueue(ForSearch);

                    hashtable.Add(Data.FirstPart, ForSearch);
                    dictionary.Add(Data.FirstPart, ForSearch);

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
    }
}