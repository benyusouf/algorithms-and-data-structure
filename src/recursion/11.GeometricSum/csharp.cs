using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(GeoSum(4));
  }

  static decimal GeoSum(int k){
    if(k == 0) return 1;

    return GeoSum(k-1) + (Decimal.Divide(1, Power(2, k)));
  }

  static int Power(int n, int m){
    if(m == 1) return n;

    return n * Power(n, m-1);
  }
}