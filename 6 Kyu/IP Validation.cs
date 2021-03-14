using System;
using System.Linq;
namespace Solution
{
    class Kata
    {
        public static bool is_valid_IP(string ipAddres)
        {
            var arr = ipAddres.Split('.');
            return arr.Length == 4 && arr.Where(x => x.Length > 1).All(x => x.Substring(0, 1) != "0") &&
                    ipAddres.ToCharArray().Count(x => char.IsNumber(x) || x == '.') == ipAddres.Length &&
                    arr.All(x => x.Length > 0) && !arr.Any(x => int.Parse(x) < 0 || int.Parse(x) > 255);
        }
    }
}