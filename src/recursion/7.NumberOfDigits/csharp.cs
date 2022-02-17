using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(FindDigits(432666));
  }

  static int FindDigits(int n){
    if(n < 10) return 1;

    return FindDigits(n/10) + 1;
  }
}