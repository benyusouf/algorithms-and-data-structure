using System;

class Program {
  public static void Main (string[] args) {
    int[] arr = new int[96];
    Console.WriteLine (MinimumSteps3(95));
  }

  public static int MinimumSteps(int n){
    if(n == 0 || n == 1) return 0;

    int x = int.MaxValue, y = int.MaxValue, z = int.MaxValue;

    x = MinimumSteps(n-1);

    if(n % 2 == 0){
      y = MinimumSteps(n/2);
    }

    if(n % 3 == 0){
      z = MinimumSteps(n/3);
    }

    return Math.Min(x, Math.Min(y, z)) + 1;
  }

  public static int MinimumSteps2(int n, int[] arr){
    if(n == 0 || n == 1) return 0;
    
    if(arr[n] != 0) return arr[n];
    
    int x = int.MaxValue, y = int.MaxValue, z = int.MaxValue;

    x = MinimumSteps(n-1);

    if(n % 2 == 0){
      y = MinimumSteps(n/2);
    }

    if(n % 3 == 0){
      z = MinimumSteps(n/3);
    }

    int ans = Math.Min(x, Math.Min(y, z)) + 1;

    arr[n] = ans;

    return ans;
  }

  public static int MinimumSteps3(int n){
    if(n == 0 || n == 1) return 0;

    int[] arr = new int[n+1];
    arr[0] = 0;
    arr[1] = 0;

    for(int i = 2; i < arr.Length; i++){
      int x = int.MaxValue, y = int.MaxValue, z = int.MaxValue;

      x = MinimumSteps(i-1);
  
      if(i % 2 == 0){
        y = MinimumSteps(i/2);
      }
  
      if(i % 3 == 0){
        z = MinimumSteps(i/3);
      }

      arr[i] = Math.Min(x, Math.Min(y, z)) + 1;
    }

    
    return arr[n];
  }
}