using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment
{
    public static class Iterators
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (var list in items)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var item in items)
            {
                if(predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static bool Even(int i)
        {
            if(i%2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}