namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public bool InviteMoreWomen(int[] L)
        {
            int sum = 0;
            for (int i = 0; i < L.Length; i++)
            {
                sum += L[i];
            }
            if(sum > 0) return true;
            else return false;         
        }
    }
}