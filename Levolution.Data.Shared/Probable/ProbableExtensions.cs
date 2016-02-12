using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Levolution.Data
{
    public static class ProbableExtensions
    {
        private static Random DefaultRandom { get; } = new Random();

        public static IProbable Choose(this IEnumerable<IProbable> items)
            => items.Choose(DefaultRandom);

        public static IProbable Choose(this IEnumerable<IProbable> items, Random random)
        {
            if (!items.Any())
            {
                throw new ArgumentException("The items parameter is empty.", nameof(items));
            }

            var array = items.OrderByDescending(x => x.Probability).ToArray();
            var sum = array.Sum(x => x.Probability);
            var p = random.NextDouble() * sum;

            foreach(var item in array)
            {
                if (p <= item.Probability) { return item; }
                p -= item.Probability;
            }
            return array[array.Length - 1];
        }
    }
}
