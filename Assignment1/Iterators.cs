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

        public static IEnumerable<int> Filter<T>(IEnumerable<int> items, Predicate<T> predicate)
        {
            foreach(int item in items)
            {
                Predicate<int> even = Even;
                if(even(item))
                {
                    yield return item;
                }
            }
            
        }
        public static bool Even(int i)
        {
            return i % 2 == 0;
        }
    }
}
