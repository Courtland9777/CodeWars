class Kata
{
    public static int MaxNumber(int n)
    {
        int[] count = new int[10];

        string str = n.ToString();

        for (int i = 0; i < str.Length; i++)
            count[str[i] - '0']++;

        int result = 0, multiplier = 1;

        for (int i = 0; i <= 9; i++)
        {
            while (count[i] > 0)
            {
                result += (i * multiplier);
                count[i]--;
                multiplier *= 10;
            }
        }

        return result;
    }
}