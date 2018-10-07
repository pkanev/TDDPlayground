using System;
using System.Collections.Generic;

namespace UniqueInOrder
{
    public class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var result = new List<T>();
            var previous = default(T);
            foreach (var item in iterable)
                if(!item.Equals(previous))
                {
                    result.Add(item);
                    previous = item;
                }

            return result;
        }
    }
}
