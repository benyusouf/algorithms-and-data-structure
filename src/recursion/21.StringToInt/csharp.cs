using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine (ConvertToInt("45322"));
  }

  static int ConvertToInt(string s){
    if(s == null || s.Length == 0) return 0;
    return ToInt(s, 0, 0);
  }

  static int ToInt(string s, int ans, int e){
    if(e == s.Length) return ans;

    return ToInt(s, ((ans * 10) + s[e] - '0'), e+1);
  }
}