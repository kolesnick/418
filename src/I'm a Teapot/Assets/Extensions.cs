using System.Collections.Generic;
using System.Linq;
using Entitas;

namespace ImATeapot
{
    public static class Extensions
    {
        public static IEnumerable<(T, T)> Zip<T>(this (IGroup<T>, IGroup<T>) groups)
            where T : class, IEntity =>
            Enumerable.Zip(
                groups.Item1.AsEnumerable(),
                groups.Item2.AsEnumerable(),
                (first, second) => (first, second));
    }
}
