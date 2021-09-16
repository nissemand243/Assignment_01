using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class Iterators
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (IEnumerable<T> item in items)
            {
                foreach(T i in item)
                {
                    yield return i;
                }
            }
        }


        public static IEnumerable<string> Filter<T>(IEnumerable<string> items, Predicate<T> predicate)
        {
            foreach(string item in items)
            {
                Predicate<string> even = Even;

                if(even(item))
                {
                    yield return item;
                }
            }
            
        }

        public static bool Even(string i)
        {
            return  Int32.Parse(i) % 2 == 0;

        }
    }
}
