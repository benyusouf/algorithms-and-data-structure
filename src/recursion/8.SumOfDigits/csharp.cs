using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(SumOfDigits(432666));
  }

  static int SumOfDigits(int n){
    if(n < 10) return n;

    return SumOfDigits(n/10) + n%10;
  }
}