using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal static class Data
    {
        internal const string ForSearch = "search";
        private const int FirstPart = 10000,
                          SecondPart = 9999;

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
    }
}