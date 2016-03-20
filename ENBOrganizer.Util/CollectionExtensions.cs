﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ENBOrganizer.Util
{
    public static class CollectionExtensions
    {
        public static void AddAll<T>(this ObservableCollection<T> observableCollection, List<T> list)
        {
            foreach (T item in list)
                observableCollection.Add(item);
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this List<T> list)
        {
            return new ObservableCollection<T>(list);
        }
    }
}
