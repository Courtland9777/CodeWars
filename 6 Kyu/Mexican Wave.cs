using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            if (str.Equals("")) return new List<string> { };
            char[] arr = str.ToCharArray();
            string retStr = "";
            var list = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Equals(' ')) continue;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j) retStr += arr[j].ToString().ToUpper();
                    else retStr += arr[j].ToString();
                }
                list.Add(retStr);
                retStr = "";
            }
            return list;
        }
    }
}