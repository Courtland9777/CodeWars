namespace Solution {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Kata {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            var list = new List<Tuple<char, int>>();
            foreach (var groups in input.GroupBy(s => s)
                .Select(n => new {
                    name = n.Key,
                    count = n.Count()
                }))
            {
                list.Add(new Tuple<char, int>(groups.name, groups.count));
            }

            return list;
        }
    }
}