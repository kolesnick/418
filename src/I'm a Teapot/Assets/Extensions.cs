using System;
using System.Collections.Generic;
using System.Linq;
using Entitas;

namespace ImATeapot
{
    public static class Extensions
    {
        private static readonly Random Randomizer = new Random();

        public static IEnumerable<(T, T)> Zip<T>(this (IGroup<T>, IGroup<T>) groups)
            where T : class, IEntity =>
            (groups.Item1.AsEnumerable(), groups.Item2.AsEnumerable()).Zip();

        public static IEnumerable<(T, T)> Zip<T>(this (IEnumerable<T>, IGroup<T>) groups)
            where T : class, IEntity =>
            (groups.Item1, groups.Item2.AsEnumerable()).Zip();

        public static IEnumerable<(T, T)> Zip<T>(this (IEnumerable<T>, IEnumerable<T>) groups)
            where T : class, IEntity =>
            Enumerable.Zip(
                groups.Item1.AsEnumerable(),
                groups.Item2.AsEnumerable(),
                (first, second) => (first, second));

        public static List<T> Shuffle<T>(this IGroup<T> group) where T : class, IEntity =>
            @group.AsEnumerable().Shuffle();

        public static List<T> Shuffle<T>(this IEnumerable<T> enumerable)
        {
            var list = enumerable.ToList();

            int decrementalIndex = list.Count;
            while (decrementalIndex > 1)
            {
                decrementalIndex--;
                int randomIndex = Randomizer.Next(decrementalIndex + 1);

                var value = list[randomIndex];
                list[randomIndex] = list[decrementalIndex];
                list[decrementalIndex] = value;
            }

            return list;
        }
    }
}
