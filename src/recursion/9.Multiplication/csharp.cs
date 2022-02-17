using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine(Multiplication(4, 6));
  }

  static int Multiplication(int n, int m){
    if(m == 1) return n;

    return Multiplication(n, m-1) + n;
  }
}