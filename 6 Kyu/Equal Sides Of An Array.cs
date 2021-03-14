using System.Linq;
public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    int size = arr.Length;
    int right_sum = 0;  
    int left_sum = 0; 
      
    for (int i = 1; i < size; i++) 
        right_sum += arr[i]; 
  
    for (int i = 0, j = 1;  
             j < size; i++, j++) 
    { 
        right_sum -= arr[j]; 
        left_sum += arr[i]; 
  
        if (left_sum == right_sum) 
        {         
            return i + 1; 
        }
    } 
    if (arr.Skip(1).Take(size - 1).Sum() == 0)
    {
      return 0;
    }
    return -1; 
  }
}