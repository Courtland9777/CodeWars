using System.Net;
public class Kata
{
  public static string UInt32ToIP(uint address)
  {
      IPAddress Ipv4 = new IPAddress(new byte[] { 
          (byte)((address>>24) & 0xFF) ,
          (byte)((address>>16) & 0xFF) , 
          (byte)((address>>8)  & 0xFF) , 
          (byte)( address & 0xFF)});
          
      return Ipv4.ToString();
  }
}