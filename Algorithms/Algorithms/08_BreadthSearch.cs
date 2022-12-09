using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class BreadthSearch
    {
        private static Dictionary<string, string[]> _graph = new Dictionary<string, string[]>();

        internal static void BreadthSearchSample()
        {
            _graph.Add("you", new[] { "alice", "bob", "claire" });
            _graph.Add("bob", new[] { "anuj", "peggy" });
            _graph.Add("alice", new[] { "peggy" });
            _graph.Add("claire", new[] { "thom", "jonny" });
            _graph.Add("anuj", Array.Empty<string>());
            _graph.Add("peggy", Array.Empty<string>());
            _graph.Add("thom", Array.Empty<string>());
            _graph.Add("jonny", Array.Empty<string>());
            Search("you");
        }

        private static bool Search(string name)
        {
            var searchQueue = new Queue<string>(_graph[name]);
            var checkedPeople = new List<string>();
            while (searchQueue.Any())
            {
                var person = searchQueue.Dequeue();
                if (!checkedPeople.Contains(person))
                {
                    if (PersonIsSeller(person))
                    {
                        Console.WriteLine($"{person} is a mango seller");
                        return true;
                    }
                    else
                    {
                        searchQueue = new Queue<string>(searchQueue.Concat(_graph[person]));
                        checkedPeople.Add(person);
                    }
                }
            }
            return false;
        }

        private static bool PersonIsSeller(string name)
        {
            return name.EndsWith("m");
        }

    }
}
