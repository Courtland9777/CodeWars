using System;
using System.Collections.Generic;
using System.Linq;
    public class Kata
    {
        public static bool Validate_hello(string greetings)
        {
          var list = new List<string>()
          {"hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc"};
          return list.Any(x => greetings.ToLower().Contains(x));
        }
    }