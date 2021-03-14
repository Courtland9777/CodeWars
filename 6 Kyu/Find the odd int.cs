namespace Solution
{
  class Kata
    {
        public static int find_it(int[] seq)
        {

        int res = 0; 
        for (int i = 0; i < seq.Length; i++)  
        { 
            res ^= seq[i]; 
        } 
        return res; 
        }
    }
}