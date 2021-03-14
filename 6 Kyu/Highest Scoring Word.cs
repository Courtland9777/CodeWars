public class Kata
{
  public static string High(string s)
  {
    var wordArr = s.Split(' ');
    string retStr = "";
    int highWordScore = 0;
    for (int i = 0; i < wordArr.Length; i++)
    {
        var charArr = wordArr[i].ToCharArray();
        int tempVal = 0;
        for (int j = 0; j < charArr.Length; j++)
        {
            tempVal += charArr[j] - 'a';
        }

        if (tempVal > highWordScore)
        {
            highWordScore = tempVal;
            retStr = wordArr[i];
        }
    }

    return retStr;
  }
}