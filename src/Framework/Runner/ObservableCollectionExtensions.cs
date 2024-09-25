using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace RTF.Framework
{
    public static class ObservableCollectionExtensions
    {
        public static ObservableCollection<T> Sorted<T, TKey>(this ObservableCollection<T> coll, Func<T, TKey> keySelector )
        {
            var oc = new ObservableCollection<T>();
            foreach (var i in coll.OrderBy(keySelector))
            {
                oc.Add(i);
            }
            return oc;
        }

    }
}
