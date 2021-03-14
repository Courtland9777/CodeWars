using System;
using System.Linq;

namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public string ReverseLetter(string str)
        {
          return string.Join("",str.ToCharArray().Where(char.IsLetter).Reverse());
        }
    }
}