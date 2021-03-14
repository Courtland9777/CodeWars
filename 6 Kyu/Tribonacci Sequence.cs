public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    if(n==0) return new double[0];
    double[] dp = new double[n];
    dp[0] = signature[0];
    if (n==1) return dp;
    dp[1] = signature[1];
    if (n==2) return dp;
    dp[2] = signature[2];
    if (n==3) return signature;

    for (int i = 3; i < n; i++)
        dp[i] = dp[i - 1] +
                dp[i - 2] +
                dp[i - 3];
    return dp;
  }
}