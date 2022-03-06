using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    int[] arr = {1,1,3,2,2,5,7,5,55,8,5,9};

    var result = RemoveDuplicates(arr);

    foreach(int i in result){
      Console.WriteLine (i);
    }
  }

  public static IList<int> RemoveDuplicates(int[] arr){
    IList<int> result = new List<int>();
    Dictionary<int, bool> dic = new Dictionary<int, bool>();

    for(int i = 0; i < arr.Length; i++){
      if(!dic.ContainsKey(arr[i])){
        dic.Add(arr[i], true);
        result.Add(arr[i]);
      }
    }

    return result;
  }
}