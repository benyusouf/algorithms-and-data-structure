/// <summary>
/// https://www.interviewbit.com/problems/find-permutation/
///  https://leetcode.com/articles/find-permutation/#
/// </summary>
/*
Given a positive integer n and a string s consisting only of letters D or I, you have to find any permutation of first n positive integer that satisfy the given input string.

D means the next number is smaller, while I means the next number is greater.

Notes

Length of given string s will always equal to n - 1
Your solution should run in linear time and space.
*/
public class Solution {
    public static int[] findPerm(string A, int B) {
    int s = 1, e = B;
    int[] ans = new int[B];

    for(int i = 0; i < A.Length; i++){
        if(A[i] == 'D') {
            ans[i] = e;
            e--;
        }
        else{
            ans[i] = s;
            s++;
        }
    }

    ans[B-1] = s;

    return ans;
}
}