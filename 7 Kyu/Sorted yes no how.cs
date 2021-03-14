public class Kata
{
  public static string IsSortedAndHow(int[] array)
  {
      if (IsSorted(array)) return "yes, ascending";
      return IsSortedDec(array) ? "yes, descending" : "no";
  }

  public static bool IsSorted(int[] arr)
  {
      for (int i = 1; i < arr.Length; i++)
      {
          if (arr[i - 1] > arr[i])
          {
              return false;
          }
      }
      return true;
  }

  public static bool IsSortedDec(int[] arr)
  {
      for (int i = 1; i < arr.Length; i++)
      {
          if (arr[i - 1] < arr[i])
          {
              return false;
          }
      }
      return true;
  }
}