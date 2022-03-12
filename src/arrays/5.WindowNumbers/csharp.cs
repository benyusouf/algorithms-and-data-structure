/*
You are given an array of N integers, A1, A2 ,..., AN and an integer B. Return the of count of distinct numbers in all windows of size B.

Formally, return an array of size N-B+1 where i'th element in this array contains number of distinct elements in sequence Ai, Ai+1 ,..., Ai+B-1.

NOTE:  if B > N, return an empty array.
*/

/// <summary>
/// https://www.interviewbit.com/problems/distinct-numbers-in-window/
/// </summary>
class Solution {
    public List<int> dNums(List<int> A, int B) {
        List<int> result = new List<int>();

        if(B > A.Count) return result;
        Dictionary<int, int> checker = new Dictionary<int, int>();

        for(int i = 0; i < B; i++){
            if(!checker.ContainsKey(A[i]))
                checker.Add(A[i], 1);
            else checker[A[i]]++;
        }

        result.Add(checker.Count());

        for(int i = B; i < A.Count; i++){
            if(!checker.ContainsKey(A[i]))
                checker.Add(A[i], 1);
            else checker[A[i]]++;

            if(checker.ContainsKey(A[i-B])){
                checker[A[i-B]]--;
                if(checker[A[i-B]] == 0) checker.Remove(A[i-B]);
            }

            result.Add(checker.Count());
        }

        return result;
    }
}
