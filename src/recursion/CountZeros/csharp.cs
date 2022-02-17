using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(CountZeros(2222));
  }

  static int CountZeros(int n){
    if(n < 10) return 0;

    return CountZeros(n/10) + Convert.ToInt32((n % 10 == 0));
  }
}