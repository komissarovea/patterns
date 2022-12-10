using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class GreedySetCovering
    {
        internal static void Sample()
        {
            var fruits = new HashSet<string> { "avocado", "tomato", "banana"};
            var vegetables = new HashSet<string> { "beets", "carrots", "tomato" };
            Console.WriteLine(string.Join(", ", fruits));
            Console.WriteLine(string.Join(", ", vegetables));
            Console.WriteLine();

            Console.WriteLine(string.Join(", ", fruits.Union(vegetables)));
            Console.WriteLine(string.Join(", ", fruits.Intersect(vegetables)));
            Console.WriteLine(string.Join(", ", fruits.Except(vegetables)));
            Console.WriteLine(string.Join(", ", vegetables.Except(fruits)));
            Console.WriteLine();

            var states_needed = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
            var stations = new Dictionary<string, HashSet<string>>();
            stations.Add("kone", new HashSet<string> { "id", "nv", "ut" });
            stations.Add("ktwo", new HashSet<string> { "wa", "id", "mt" });
            stations.Add("kthree", new HashSet<string> { "or", "nv", "ca" });
            stations.Add("kfour", new HashSet<string> { "nv", "ut" });
            stations.Add("kfive", new HashSet<string> { "ca", "az" });
            var final_stations = new HashSet<string>();

            while (states_needed.Any())
            {
                string best_station = null;
                var states_covered = new HashSet<string>();
                foreach (var station in stations)
                {
                    var states_for_station = station.Value;
                    var covered = new HashSet<string>(states_needed.Intersect(states_for_station));
                    if (covered.Count > states_covered.Count)
                    {
                        best_station = station.Key;
                        states_covered = covered;
                    }
                }
                if (best_station == null)
                    break;
                states_needed.RemoveWhere(s => states_covered.Contains(s));
                final_stations.Add(best_station);
            }

            Console.WriteLine(string.Join(", ", final_stations));
        }

    }
}
