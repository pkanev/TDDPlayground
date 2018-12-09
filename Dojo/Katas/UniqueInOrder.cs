namespace Katas
{
    using System.Collections.Generic;

    public class UniqueInOrder
    {
        public static IEnumerable<T> ToUniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var result = new List<T>();
            var previous = default(T);
            foreach (var item in iterable)
                if (!item.Equals(previous))
                {
                    result.Add(item);
                    previous = item;
                }

            return result;
        }
    }
}
