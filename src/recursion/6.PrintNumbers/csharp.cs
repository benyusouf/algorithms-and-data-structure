
public class Solution {
    public void PrintNumbers(int n){
        if(n == 0) return;
        PrintNumbers(n-1);
        Console.WriteLine(n);
    }

    public void PrintNumbers2(int n){
        if(n == 0) return;
        Console.WriteLine(n);
        PrintNumbers(n-1);
        
    }
    
}