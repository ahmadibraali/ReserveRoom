using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveRoom.Extensions
{
    public static class ObservableExtensions
    {
        public static ObservableCollection<TSource> ToObservable<TSource>(this IEnumerable<TSource> Tsource)
        {
            ObservableCollection<TSource> res = new ObservableCollection<TSource>();
            if (Tsource is not null)
            {
                foreach(var item in Tsource)
                {
                    res.Add(item);
                }
            }
            return res;
        }
        public static ObservableCollection<TSource> ToObservable<TSource>(this List<TSource> Tsource)
        {
            ObservableCollection<TSource> res = new ObservableCollection<TSource>();
            if (Tsource is not null)
            {
                foreach (var item in Tsource)
                {
                    res.Add(item);
                }
            }
            return res;
        }
        public static ObservableCollection<TSource> ToObservable<TSource>(this TSource[] Tsource)
        {
            ObservableCollection<TSource> res = new ObservableCollection<TSource>();
            if (Tsource is not null)
            {
                foreach (var item in Tsource)
                {
                    res.Add(item);
                }
            }
            return res;
        }

    }
}
