using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    
    public static int Fibonacci(int n) {

        //int[] arr = new int[n+1];
        // Write your code here.
     return FibonacciBottom(n);
    }
    
    public static int FibonacciBottom(int n){
        if(n < 2) return n;
        
        int[] arr = new int[n+1];
        arr[0] = 0;
        arr[1] = 1;
        
        for(int i = 2; i < arr.Length; i++){
            arr[i] = arr[i-1] + arr[i-2];
        }
        return arr[n];
    }
    
    public static int FibonacciTop(int n, int[] arr){
        if(n < 2) return n;
        
        if(arr[n] != 0) return arr[n];
        
        int result = FibonacciTop(n-1, arr) + FibonacciTop(n-2, arr);
        
        arr[n] = result;
        
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}