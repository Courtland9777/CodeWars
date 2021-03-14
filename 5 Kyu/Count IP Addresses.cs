using System;
using System.Net;
public class CountIPAddresses
{
    public static long IpsBetween(string start, string end)
    {
        return ToInt(end) - ToInt(start);   
    }
    
    public static long ToInt(string addr)
    {
        return (long) (uint) IPAddress.NetworkToHostOrder((int) IPAddress.Parse(addr).Address);
    }
}