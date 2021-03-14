public class Kata
{
  public static object FirstNonConsecutive(int[] arr)
  {
    int? x = null;
    foreach (var item in arr)
    {
        if(x==null) x = item;
        else
        {
            if((x+1)!=item) return item; 
            else x++;
        }
    }
    return null;
  }
}