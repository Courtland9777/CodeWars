using System;
using System.Linq;
public class DirReduction {
  
    public static string[] dirReduc(String[] arr) {
        string chk1 = "";
        string chk2 = "";
        int arrLenCheck = 0;
        int arrLen = 0;
        
        do
        {
            arrLen = arr.Length;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (!arr[i].Equals(""))
                {
                    chk1 = arr[i];
                    chk2 = arr[i+1];
        
                    switch (chk1)
                    {
                        case "NORTH":
                            if (chk2.Equals("SOUTH"))
                            {
                                arr[i] = "";
                                arr[i+1] = "";
                            }
                            break;
                        case "SOUTH":
                            if(chk2.Equals("NORTH"))
                            {
                                arr[i] = "";
                                arr[i+1] = "";
                            }
                            break;
                        case "EAST":
                            if(chk2.Equals("WEST"))
                            {
                                arr[i] = "";
                                arr[i+1] = "";
                            }
                            break;
                        case "WEST":
                            if(chk2.Equals("EAST"))
                            {
                                arr[i] = "";
                                arr[i+1] = "";
                            }
                            break;     
                    }
                    string myStringOutput = String.Join(",", arr.Where(p => p != "").Select(p => p.ToString()).ToArray());
                    arr = myStringOutput.Split(',');                    
                }
                arrLenCheck = arr.Length;
            }
        }while(arrLen != arrLenCheck);
        return arr;
    }
}