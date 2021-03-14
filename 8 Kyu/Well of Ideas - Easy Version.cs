public class Kata
{
  public static string Well(string[] x)
  {   
      int gIdea = 0, bIdea = 0;
      for(int i = 0; i < x.Length; i++)
      {
          if(x[i].Equals("good")) gIdea++;
          else bIdea++;
      }
      if(gIdea > 2) return "I smell a series!";
      else if(gIdea == 1 || gIdea == 2) return "Publish!";
      else return "Fail!";
    }  
}