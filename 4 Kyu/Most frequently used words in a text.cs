using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class TopWords
{
    public static List<string> Top3(string message)
    {
        Console.WriteLine(message);
    
        if (message.Length == 0) return new List<string>();
            var frequencies = new Dictionary<string, int>();

            string clnMessage = Regex.Replace(message, @"[\'-'\p{P}-['\-.]]", " ");
            clnMessage = clnMessage.Replace("-", " ");

            var splichar = new char[] { ' ', '.' };
            var single = clnMessage.ToLower().Split(splichar, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in single)
            {
                frequencies.TryGetValue(item, out var freq);
                freq++;

                frequencies[item] = freq;
            }

            var list = new List<string>();
             
            switch (frequencies.Count)
            {
                case 1:
                    if (frequencies.First().Key.Equals("'") || frequencies.First().Key.Equals("'''")) return list;
                    list.Add(frequencies.First().Key);
                    return list;
                case 2:
                    var t3 = frequencies.OrderByDescending(x => x.Value).Take(2).ToList();
                    list.AddRange(from item in t3 where !item.Key.Equals("'") && !item.Key.Equals("'''") select item.Key);
                    return list;
                default:
                    t3 = frequencies.OrderByDescending(x => x.Value).Take(3).ToList();
                    list.AddRange(from item in t3 where !item.Key.Equals("'") && !item.Key.Equals("'''") select item.Key);
                    return list;
            }
        }
    }