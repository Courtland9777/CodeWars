using System.Linq;
  public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            return arr.Where((value, index) => index % 2 == 0).ToArray();
        }
    }