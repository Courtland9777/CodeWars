public class LongestConsecutives 
{
    
    public static string LongestConsec(string[] strArr, int k)
    {
        if (strArr.Length == 0 || strArr.Length < k || k < 1) return "";
        string str = "";
        int strLength = 0;
        for (int i = 0; i <= strArr.Length - k; i++)
        {
            string temp = "";
            for (int j = 0; j < k; j++)
            {
                temp += strArr[i + j];
            }

            if (temp.Length <= strLength) continue;
            str = temp;
            strLength = temp.Length;
        }

        return str;
    }
}