/// <summary>
/// https://leetcode.com/problems/jump-game-ii/submissions/
/// </summary>
/*
Given an array of non-negative integers nums, you are initially positioned at the first index of the array.

Each element in the array represents your maximum jump length at that position.

Your goal is to reach the last index in the minimum number of jumps.

You can assume that you can always reach the last index.
*/
public class Solution {
    public int Jump(int[] A) {
        int n = A.Length;
        if(n==1) return 0;
        if(A[0]==0) return -1;
        
        int ladder = A[0];    /// biggest ladder/ max reachable Index
        int stair = A[0];     /// current ladder
        int jump = 1;
        
        for(int i=1;i<n;i++){
            if(i==n-1) return jump;
            
            if(i+A[i] > ladder){
                ladder = i + A[i];
            }
            
            stair--; /// traversing current ladder
            
            if(stair==0){    // current ladder finished
                jump++;
                if(i>=ladder) return -1;
                stair = ladder - i;
            }
        }
        
        return -1;
    }
}