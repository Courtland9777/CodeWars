using System; 

public class Kata
{
  public static int[] TwoSum(int[] numbers, int target)
  {
   
                                    // int[] A, int arr_size, int sum
    int l, r; 
    int[] result = new int[2];
        /* Sort the elements */
        Array.Sort(numbers); 
  
        /* Now look for the two candidates  
        in the sorted array*/
        l = 0; 
        r = numbers.Length - 1; 
        while (l < r) { 
            if (numbers[l] + numbers[r] == target) 
            {
                result[0] = l;
                result[1] = r;
                return result; 
            }
            else if (numbers[l] + numbers[r] < target) 
                l++; 
            else
                r--; 
        } 
        return numbers; 
  }
}