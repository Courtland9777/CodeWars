public class Kata
{
  public static bool IsValidWalk(string[] walk)
    {
        if(walk.Length != 10)
        {
            return false;
        }
        int nsCounter = 0;
        int ewCounter = 0;
        
        for(int i = 0; i < walk.Length; i++)
        {
            switch(walk[i])
            {
                case "n":
                    nsCounter++;
                    break;
                case "s":
                    nsCounter--;
                    break;
                case "e":
                    ewCounter++;
                    break;
                case "w":
                    ewCounter--;
                    break;            
            }
        }
        if(ewCounter == 0 && nsCounter == 0)
        {
            return true;
        }
        return false;
    }
}